using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Application.DataSPKKendaraanDBs.Command.CreateDataSPKKendaraanDB
{
    public class CreateDataSPKKendaraanDBCommandHandler : IRequestHandler<CreateDataSPKKendaraanDBCommand>
    {

        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;

        public CreateDataSPKKendaraanDBCommandHandler(
            ISMMCoreDDD2019DbContext context,
            INotificationService notificationService,
            IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;
        }
        public async Task<Unit> Handle(CreateDataSPKKendaraanDBCommand request, CancellationToken cancellationToken)
        {
            var entity = new DataSPKKendaraanDB
            {
              //  NoUrut = request.NoUrut,
                NamaSTNK= request.NamaSTNK,
                NoKtpSTNK = request.NoKtpSTNK,
                MasterBarangDBId = request.NoUrutTypeKendaraan,
                DataSPKBaruDBId = request.NoUrutSPKBaru,
                TahunPerakitan= request.TahunPerakitan,
                Warna = request.Warna



            };

            _context.DataSPKKendaraanDB.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

           await _mediator.Publish(new DataSPKKendaraanDBCreated { DataSPKKendaraanDBID = entity.Id.ToString() });

            return Unit.Value;

            // throw new NotImplementedException();
        }
    }
}
