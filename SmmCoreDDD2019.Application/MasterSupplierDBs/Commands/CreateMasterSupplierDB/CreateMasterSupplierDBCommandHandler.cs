using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Exceptions;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;


namespace SmmCoreDDD2019.Application.MasterSupplierDBs.Commands.CreateMasterSupplierDB
{
    public class CreateMasterSupplierDBCommandHandler : IRequestHandler<CreateMasterSupplierDBCommand>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;
        public CreateMasterSupplierDBCommandHandler(SMMCoreDDD2019DbContext context, 
            INotificationService notificationService,
                IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;

        }


        public async Task<Unit> Handle(CreateMasterSupplierDBCommand request, CancellationToken cancellationToken)
        {
            var entity = new MasterSupplierDB
            {
                NoRegistrasiSupplier= DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper() + "REGSUPP",

                Aktif = request.Aktif,
                Alamat = request.Alamat,
                Kelurahan = request.Kelurahan,
                Kecamatan = request.Kecamatan,
                Kota = request.Kota,
                Propinsi = request.Propinsi,
                KodePos = request.KodePos,
                NamaSupplier = request.NamaSupplier,
                Telp = request.Telp,
                Faks = request.Faks,
                Email = request.Email

            };

            _context.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            await _mediator.Publish(new CreateMasterSupplierDBCreated { MasterSupplierID = entity.IDSupplier.ToString()});
            return Unit.Value;

            //throw new System.NotImplementedException();
        }
    }
}
