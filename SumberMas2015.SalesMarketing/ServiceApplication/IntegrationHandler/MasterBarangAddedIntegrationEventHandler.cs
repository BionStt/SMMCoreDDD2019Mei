using MediatR;
using SumberMas2015.IntegrationEvent;
using SumberMas2015.SalesMarketing.ServiceApplication.MasterBarang.Commands.CreateMasterBarang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.IntegrationHandler
{
    public class MasterBarangAddedIntegrationEventHandler : INotificationHandler<MasterBarangAddedIntegrationEvent>
    {
        private readonly IMediator _mediator;

        public MasterBarangAddedIntegrationEventHandler(IMediator mediator)
        {
            _mediator=mediator;
        }

        public async Task Handle(MasterBarangAddedIntegrationEvent notification, CancellationToken cancellationToken)
        {
            await _mediator.Send(new CreateMasterBarangCommand
            {
                BBn= notification.BBN,
                HargaOff = notification.HargaOffTheRoad,
                KapasitasMesin = notification.KapasitasMesin,
                Merek = notification.Merek,
                NamaBarang =notification.NamaBarang,
                NomorMesin=notification.NomorMesin,
                NomorRangka=notification.NomorRangka,
                TahunPerakitan=notification.TahunPerakitan,
                TypeKendaraan=notification.TypeKendaraan

            });
        }
    }
}
