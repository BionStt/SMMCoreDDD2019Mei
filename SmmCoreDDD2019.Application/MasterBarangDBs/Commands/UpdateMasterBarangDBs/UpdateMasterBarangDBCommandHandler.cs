using System;
using System.Collections.Generic;
using System.Text;

using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SmmCoreDDD2019.Application.Exceptions;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Application.Interfaces;

namespace SmmCoreDDD2019.Application.MasterBarangDBs.Commands.UpdateMasterBarangDBs
{
    public class UpdateMasterBarangDBCommandHandler : IRequestHandler<UpdateMasterBarangDBCommand>
    {
        private readonly ISMMCoreDDD2019DbContext _context;

        public UpdateMasterBarangDBCommandHandler(ISMMCoreDDD2019DbContext context)
        {
            _context = context;
        }


        public async Task<Unit> Handle(UpdateMasterBarangDBCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.MasterBarangDB.FindAsync(request.NoUrutTypeKendaraan);

            if (entity==null)
            {
                throw new NotFoundException(nameof(MasterBarangDB), request.NoUrutTypeKendaraan);
            }

            entity.Aktif = request.Aktif;
            entity.BBN = request.BBN;
            entity.Cc= request.Cc;
            entity.Harga= request.Harga;
            entity.Merek = request.Merek;
            entity.NamaBarang = request.NamaBarang;
            entity.NomorMesin = request.NomorMesin;
            entity.NomorRangka = request.NomorRangka;
            entity.Tahun = request.Tahun;
            entity.Tipe = request.Tipe;
            entity.TypeKendaraan = request.TypeKendaraan;
           
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
            //  throw new NotImplementedException();
        }
    }
}
