using System;
using System.Collections.Generic;
using System.Text;

using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;

namespace SmmCoreDDD2019.Application.MasterLeasingCabangDBs.Commands.CreateMasterLeasingCabangDB
{
    public class CreateMasterLeasingCabangDBHandler : IRequestHandler<CreateMasterLeasingCabangDBCommand, Unit>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;

        public CreateMasterLeasingCabangDBHandler(
            SMMCoreDDD2019DbContext context,
            INotificationService notificationService,
            IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;
        }

        public async Task<Unit> Handle(CreateMasterLeasingCabangDBCommand request, CancellationToken cancellationToken)
        {

            var entity = new MasterLeasingCabangDB
            {
                IDlease = request.IDlease,
                Aktif = request.Aktif,
                Alamat = request.Alamat,
                Kelurahan= request.Kelurahan,
                Kecamatan= request.Kecamatan,
                Kota= request.Kota,
                Propinsi= request.Propinsi,
                KodePos= request.KodePos,
                Cabang= request.Cabang,
                Telp= request.Telp,
                Faks = request.Faks,
                Email = request.Email
            };

            _context.MasterLeasingCabangDB.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            await _mediator.Publish(new CreateMasterLeasingCabangDBCreated { MasterLeasngCabangID = entity.NoUrutLeasingCabang.ToString() });

            return Unit.Value;

            //throw new NotImplementedException();
        }
    }
}
