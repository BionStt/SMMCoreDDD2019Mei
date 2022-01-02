using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.WorkerProcess
{
    public class SalesMarketingInternalCommandsWorker: BackgroundService
    {

        private readonly ILogger<SalesMarketingInternalCommandsWorker> _logger;
        private readonly IServiceProvider _serviceProvider;

        public SalesMarketingInternalCommandsWorker(ILogger<SalesMarketingInternalCommandsWorker> logger, IServiceProvider serviceProvider)
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
                var messages = await services.dbContext.InternalCommands.Where(x => x.ExecutedOn == null)
                    .ToListAsync(stoppingToken);

                foreach (var internalCommandMessage in messages)
                {
                    try
                    {
                        var eventMessage = internalCommandMessage.RecreateMessage();

                        //await services.mediator.Publish(eventMessage, CancellationToken.None);
                        await services.mediator.Send(eventMessage, CancellationToken.None);

                        internalCommandMessage.ExecutedOn = DateTime.UtcNow;
                        await services.dbContext.SaveChangesAsync(CancellationToken.None);

                        _logger.LogInformation("[InternalCommand] Message handled: {MessageId}", internalCommandMessage.Id);

                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, "[InternalCommand] Exception when handling message. Message body: {message}", internalCommandMessage.Message);
                    }
                }

                await Task.Delay(1000, stoppingToken);
            }
        }

        private (IMediator mediator, SalesMarketingContext dbContext) GetServices(IServiceScope scope)
        {
            var internalCommandDbContext = scope.ServiceProvider.GetService<SalesMarketingContext>();
            if (internalCommandDbContext == null)
                throw new ArgumentNullException(nameof(SalesMarketingContext), "Cant resolve OutboxDbContext from service provider");

            var mediator = scope.ServiceProvider.GetService<IMediator>();
            if (mediator == null)
                throw new ArgumentNullException(nameof(IMediator), "Cant resolve IMediator from service provider");

            return (mediator, internalCommandDbContext);
        }
    }
}
