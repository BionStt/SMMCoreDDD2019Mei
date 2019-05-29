using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;



namespace SmmCoreDDD2019.Application.DataPegawaiDataJabatans.Commands.CreateDataPegawaiDataJabatan
{
    public class CreateDataPegawaiDataJabatanCommandHandler : IRequestHandler<CreateDataPegawaiDataJabatanCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;

        public CreateDataPegawaiDataJabatanCommandHandler(
            ISMMCoreDDD2019DbContext context,
            INotificationService notificationService,
            IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;
        }

        public async Task<Unit> Handle(CreateDataPegawaiDataJabatanCommand request, CancellationToken cancellationToken)
        {

            var entity = new DataPegawaiDataJabatan
            {
              // NoUrut = request.NoUrut,
                IDPegawai= request.IDPegawai,
                NoUrutJabatan= request.NoUrutJabatan,
               // TglMenjabat= request.TglMenjabat,
             //   TglBerhentiMenjabat= request.TglBerhentiMenjabat,
                Keterangan = request.Keterangan
              


            };

            _context.DataPegawaiDataJabatan.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

           await _mediator.Publish(new DataPegawaiDataJabatanCreated { DataPegawaiDataJabatanID = entity.NoUrut.ToString() },cancellationToken);

            return Unit.Value;

            //   throw new NotImplementedException();
        }
    }
}
