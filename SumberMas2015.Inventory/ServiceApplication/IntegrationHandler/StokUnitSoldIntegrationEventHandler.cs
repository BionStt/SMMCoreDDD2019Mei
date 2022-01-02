using MediatR;
using SumberMas2015.IntegrationEvent;
using SumberMas2015.Inventory.ServiceApplication.Configuration.InternalCommands;
using SumberMas2015.Inventory.ServiceApplication.StokUnit.Commands.StokUnitSold;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.ServiceApplication.IntegrationHandler
{
    public class StokUnitSoldIntegrationEventHandler : INotificationHandler<StokUnitSoldIntegrationEvent>
    {
       // private readonly IMediator _mediator;
        private readonly ICommandsScheduler _commandsScheduler;

        public StokUnitSoldIntegrationEventHandler(ICommandsScheduler commandsScheduler)
        {
            _commandsScheduler=commandsScheduler;
        }

        public async Task Handle(StokUnitSoldIntegrationEvent notification, CancellationToken cancellationToken)
        {
            await _commandsScheduler.EnqueueAsync(new StokUnitSoldCommand
            {
            StokUnitId = notification.StokUnitId
            });

        }
    }
}
