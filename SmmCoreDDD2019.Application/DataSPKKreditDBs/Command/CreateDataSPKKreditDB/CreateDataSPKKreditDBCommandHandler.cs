using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;
namespace SmmCoreDDD2019.Application.DataSPKKreditDBs.Command.CreateDataSPKKreditDB
{
    public class CreateDataSPKKreditDBCommandHandler : IRequestHandler<CreateDataSPKKreditDBCommand, Unit>
    {

        private readonly SMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;

        public CreateDataSPKKreditDBCommandHandler(
            SMMCoreDDD2019DbContext context,
            INotificationService notificationService,
            IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;
        }

        public async Task<Unit> Handle(CreateDataSPKKreditDBCommand request, CancellationToken cancellationToken)
        {
            var entity = new DataSPKKreditDB
            {
               // NoUrut = request.NoUrut,
                BiayaAdministrasiKredit = request.BiayaAdministrasiKredit,
                BiayaAdministrasiTunai= request.BiayaAdministrasiTunai,
                BBN= request.BBN,
                DendaWilayah= request.DendaWilayah,
                DiskonDP= request.DiskonDP,
            DiskonTunai = request.DiskonTunai,
                DPPriceList = request.DPPriceList,
                Komisi = request.Komisi,
                NoUrutSPKBaru = request.NoUrutSPKBaru,
                OffTheRoad= request.OffTheRoad,
                Promosi = request.Promosi,
                UangTandaJadiTunai= request.UangTandaJadiTunai,
                UangTandaJadiKredit= request.UangTandaJadiKredit
             


            };

            _context.DataSPKKreditDB.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            await _mediator.Publish(new DataSPKKreditDBCreated { DataSPKKreditDBID = entity.NoUrut.ToString() });

            return Unit.Value;



            //  throw new NotImplementedException();
        }
    }
}
