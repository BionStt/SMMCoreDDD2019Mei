using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Application.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace SmmCoreDDD2019.Application.DataSPKKendaraanDBs.Command.UpdateDataSPKKendaraanDB
{
    public class UpdateDataSPKKendaraanDBCommandHandler : IRequestHandler<UpdateDataSPKKendaraanDBCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;

        public UpdateDataSPKKendaraanDBCommandHandler(ISMMCoreDDD2019DbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(UpdateDataSPKKendaraanDBCommand request, CancellationToken cancellationToken)
        {

            var entity = await _context.DataSPKKendaraanDB
              .SingleAsync(c => c.Id == request.NoUrut, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(DataSPKKendaraanDB), request.NoUrut);
            }
                //  entity.NoUrut = request.NoUrut;
                entity.NamaSTNK = request.NamaSTNK;
                entity.NoKtpSTNK = request.NoKtpSTNK;
                entity.MasterBarangDBId = request.NoUrutTypeKendaraan;
                entity.DataSPKBaruDBId = request.NoUrutSPKBaru;
                entity.TahunPerakitan = request.TahunPerakitan;
                entity.Warna = request.Warna;


            _context.DataSPKKendaraanDB.Update(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;


            //   throw new NotImplementedException();
        }
    }
}
