﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SumberMas2015.Inventory.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.InfrastructureData.WorkerProcess
{
    public class InventoryOutBoxWorker: BackgroundService
    {
        private readonly ILogger<InventoryOutBoxWorker> _logger;
        private readonly IServiceProvider _serviceProvider;

        public InventoryOutBoxWorker(ILogger<InventoryOutBoxWorker> logger, IServiceProvider serviceProvider)
        {
            _logger=logger;
            _serviceProvider=serviceProvider;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                using var scope = _serviceProvider.CreateScope();

                var services = GetServices(scope);
                var messages = await services.dbContext.OutBoxMessages.Where(x => x.ExecutedOn == null)
                    .ToListAsync(stoppingToken);

                foreach (var outBoxMessage in messages)
                {
                    try
                    {
                        var eventMessage = outBoxMessage.RecreateMessage();

                        await services.mediator.Publish(eventMessage, CancellationToken.None);

                        outBoxMessage.ExecutedOn = DateTime.UtcNow;
                        await services.dbContext.SaveChangesAsync(CancellationToken.None);

                        _logger.LogInformation("[Outbox] Message handled: {MessageId}", outBoxMessage.Id);

                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "[Outbox] Exception when handling message. Message body: {message}", outBoxMessage.Message);
                    }
                }

                await Task.Delay(1000, stoppingToken);
            }




        }
        private (IMediator mediator, InventoryContext dbContext) GetServices(IServiceScope scope)
        {
            var outBoxDbContext = scope.ServiceProvider.GetService<InventoryContext>();
            if (outBoxDbContext == null)
                throw new ArgumentNullException(nameof(InventoryContext), "Cant resolve OutboxDbContext from service provider");

            var mediator = scope.ServiceProvider.GetService<IMediator>();
            if (mediator == null)
                throw new ArgumentNullException(nameof(IMediator), "Cant resolve IMediator from service provider");

            return (mediator, outBoxDbContext);
        }

    }
}
