using MediatR;
using SumberMas2015.IntegrationEvent;
using SumberMas2015.SalesMarketing.ServiceApplication.Configuration.InternalCommands;
using SumberMas2015.SalesMarketing.ServiceApplication.StokUnit.Commands.FromInventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.IntegrationHandler
{
    public class StokUnitAddedIntegrationEventHandler : INotificationHandler<StokUnitAddedIntegrationEvent>
    {
       // private readonly IMediator _mediator;
        private readonly ICommandsScheduler _commandsScheduler;

        public StokUnitAddedIntegrationEventHandler(ICommandsScheduler commandsScheduler)
        {
            _commandsScheduler=commandsScheduler;
        }

        public async Task Handle(StokUnitAddedIntegrationEvent notification, CancellationToken cancellationToken)
        {
            var DtStokUnit = new CreateStokUnitCommand();
            DtStokUnit.StokUnitId = notification.StokUnitId;
            DtStokUnit.NomorMesin = notification.NomorMesin;
            DtStokUnit.NomorRangka = notification.NomorRangka;
            DtStokUnit.MasterBarangId = notification.MasterBarangId;
            DtStokUnit.NamaSupplier =   notification.NamaSupplier;

            await _commandsScheduler.EnqueueAsync(DtStokUnit);
            //  await _mediator.Send(DtStokUnit);


        }
    }
}
