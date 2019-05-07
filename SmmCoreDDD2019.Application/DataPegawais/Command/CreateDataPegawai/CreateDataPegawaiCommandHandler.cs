using System;
using System.Collections.Generic;
using System.Text;

using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;

namespace SmmCoreDDD2019.Application.DataPegawais.Command.CreateDataPegawai
{
    public class CreateDataPegawaiCommandHandler : IRequestHandler<CreateDataPegawaiCommand, Unit>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;

        public CreateDataPegawaiCommandHandler(
            SMMCoreDDD2019DbContext context,
            INotificationService notificationService,
            IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;
        }


        public async Task<Unit> Handle(CreateDataPegawaiCommand request, CancellationToken cancellationToken)
        {
            var entity = new DataPegawai
            {
              // IDPegawai = request.IDPegawai,
              NoRegistrasiPegawai= DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper() + "REGPEG",

                TglInput = request.TglInput,
                TglMulaiKerja = request.TglMulaiKerja,
                TglBerhentiKerja = request.TglBerhentiKerja,
                Aktif = request.Aktif,
               ApplicationUserId = request.ApplicationUserID
               
            };

            _context.DataPegawai.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

           await _mediator.Publish(new DataPegawaiCreated { DataPegawaiID = entity.IDPegawai.ToString() });

            return Unit.Value;


            //  throw new NotImplementedException();
        }
    }
}
