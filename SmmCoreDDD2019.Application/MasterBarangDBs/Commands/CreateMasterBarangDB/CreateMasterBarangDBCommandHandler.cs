using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediatR;
using SmmCoreDDD2019.Application.Exceptions;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;
using SmmCoreDDD2019.Application.Interfaces;
using System.Threading;

namespace SmmCoreDDD2019.Application.MasterBarangDBs.Commands.CreateMasterBarangDB
{
    public class CreateMasterBarangDBCommandHandler : IRequestHandler<CreateMasterBarangDBCommand, Unit>
    {

        private readonly SMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;


        public CreateMasterBarangDBCommandHandler(SMMCoreDDD2019DbContext context, INotificationService notificationService, IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;

        }
        public async Task<Unit> Handle(CreateMasterBarangDBCommand request, CancellationToken cancellationToken)
        {
            var entity = new MasterBarangDB
            {
                Aktif = request.Aktif,
                BBN = request.BBN,
                Cc = request.Cc,
                Harga = request.Harga,
                Merek = request.Merek,
                NamaBarang = request.NamaBarang,
                NomorRangka = request.NomorRangka,
                NomorMesin = request.NomorMesin,
                Tahun = request.Tahun,
                Tipe = request.Tipe,
                TypeKendaraan = request.TypeKendaraan

            };

            _context.MasterBarangDB.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
             await _mediator.Publish(new CreateMasterBarangDBCreated { MasterBarangDBID = entity.NoUrutTypeKendaraan.ToString() } );
            return Unit.Value;
         
        }
    }
}
