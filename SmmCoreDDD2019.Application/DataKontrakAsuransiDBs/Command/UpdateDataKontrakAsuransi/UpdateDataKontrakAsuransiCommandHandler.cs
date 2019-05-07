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
namespace SmmCoreDDD2019.Application.DataKontrakAsuransiDBs.Command.UpdateDataKontrakAsuransi
{
    public class UpdateDataKontrakAsuransiCommandHandler : IRequestHandler<UpdateDataKontrakAsuransiCommand, Unit>
    {
        private readonly SMMCoreDDD2019DbContext _context;

        public UpdateDataKontrakAsuransiCommandHandler(SMMCoreDDD2019DbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(UpdateDataKontrakAsuransiCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.DataKontrakAsuransi
              .SingleAsync(c => c.NoUrutDataAsuransi == request.NoUrutDataAsuransi, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(DataKontrakAsuransi), request.NoUrutDataAsuransi);
            }

            entity.NoRegistrasiKontrakKredit = request.NoRegistrasiKontrakKredit;
                entity.KodeAsuransi = request.KodeAsuransi;
               entity.JenisAsuransi = request.JenisAsuransi;
               entity.TanggalMulaiAsuransi = request.TanggalMulaiAsuransi;
              entity.TanggalAkhirAsuransi = request.TanggalAkhirAsuransi;
              entity.LamaAsuransi = request.LamaAsuransi;
               entity.NilaiPertanggungan = request.NilaiPertanggungan;
              entity.BiayaAsuransi = request.BiayaAsuransi;



            _context.DataKontrakAsuransi.Update(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
