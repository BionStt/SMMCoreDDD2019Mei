using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;


namespace SmmCoreDDD2019.Application.DataPegawaiDataOrmass.Command.CreateDataPegawaiDataOrmas
{
    public class CreateDataPegawaiDataOrmasCommandHandler : IRequestHandler<CreateDataPegawaiDataOrmasCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;

        public CreateDataPegawaiDataOrmasCommandHandler(
            ISMMCoreDDD2019DbContext context,
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
                DataPegawaiId = request.IDPegawai,
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

           await _mediator.Publish(new DataPegawaiDataOrmasCreated { DataPegawaiDataOrmassID = entity.Id.ToString() },cancellationToken);

            return Unit.Value;
            // throw new NotImplementedException();
        }
    }
}
