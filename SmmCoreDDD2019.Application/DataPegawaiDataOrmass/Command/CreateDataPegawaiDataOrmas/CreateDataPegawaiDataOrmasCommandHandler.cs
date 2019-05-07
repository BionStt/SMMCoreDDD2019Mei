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

namespace SmmCoreDDD2019.Application.DataPegawaiDataOrmass.Command.CreateDataPegawaiDataOrmas
{
    public class CreateDataPegawaiDataOrmasCommandHandler : IRequestHandler<CreateDataPegawaiDataOrmasCommand, Unit>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;

        public CreateDataPegawaiDataOrmasCommandHandler(
            SMMCoreDDD2019DbContext context,
            INotificationService notificationService,
            IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;
        }

        public async Task<Unit> Handle(CreateDataPegawaiDataOrmasCommand request, CancellationToken cancellationToken)
        {

            var entity = new DataPegawaiDataOrmas
            {
              //  NoUrut = request.NoUrut,
                IDPegawai = request.IDPegawai,
                NamaOrmas= request.NamaOrmas,
                AlamatOrmas= request.AlamatOrmas,
                KotaOrmas= request.KotaOrmas,
                TelpOrmas= request.TelpOrmas,
                Jabatan = request.Jabatan,
                JenisKegiatan= request.JenisKegiatan
              //  TglInput= request.TglInput



            };

            _context.DataPegawaiDataOrmas.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

           await _mediator.Publish(new DataPegawaiDataOrmasCreated { DataPegawaiDataOrmassID = entity.NoUrut.ToString() });

            return Unit.Value;
            // throw new NotImplementedException();
        }
    }
}
