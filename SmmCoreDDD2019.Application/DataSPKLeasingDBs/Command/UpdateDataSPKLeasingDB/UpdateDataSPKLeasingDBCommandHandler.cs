using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


using MediatR;
using Microsoft.EntityFrameworkCore;
using SmmCoreDDD2019.Application.Exceptions;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;
namespace SmmCoreDDD2019.Application.DataSPKLeasingDBs.Command.UpdateDataSPKLeasingDB
{
    public class UpdateDataSPKLeasingDBCommandHandler:IRequestHandler<UpdateDataSPKLeasingDBCommand, Unit>
    {
        private readonly SMMCoreDDD2019DbContext _context;

        public UpdateDataSPKLeasingDBCommandHandler(SMMCoreDDD2019DbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateDataSPKLeasingDBCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.DataSPKLeasingDB
              .SingleAsync(c => c.NoUrut == request.NoUrut, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(DataSPKLeasingDB), request.NoUrut);
            }

    
               entity.NoUrut = request.NoUrut;
                entity.Angsuran = request.Angsuran;
                entity.NoUrutLeasingCabang = request.NoUrutLeasingCabang;
                entity.Mediator = request.Mediator;
                entity.NamaCmo = request.NamaCmo;
                entity.NoUrutKategoriBayaran = request.NoUrutKategoriBayaran;

                entity.NoUrutKategoriPenjualan = request.NoUrutKategoriPenjualan;
                entity.NoUrutSales = request.NoUrutSales;
                entity.NoUrutSPKBaru = request.NoUrutSPKBaru;
                entity.Tenor = request.Tenor;
                entity.TglSurvei = request.TglSurvei;

            _context.DataSPKLeasingDB.Update(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;


            // throw new NotImplementedException();
        }
    }
}
