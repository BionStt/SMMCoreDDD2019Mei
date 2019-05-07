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
namespace SmmCoreDDD2019.Application.MasterPerusahaanAsuransiDBs.Command.UpdateMasterPerusahaanAsuransi
{
    public class UpdateMasterPerusahaanAsuransiCommandHandler : IRequestHandler<UpdateMasterPerusahaanAsuransiCommand, Unit>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        public UpdateMasterPerusahaanAsuransiCommandHandler(SMMCoreDDD2019DbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(UpdateMasterPerusahaanAsuransiCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.MasterPerusahaanAsuransi
               .SingleAsync(c => c.NoUrutPerusahaanAsuransi == request.NoUrutPerusahaanAsuransi, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(MasterPerusahaanAsuransi), request.NoUrutPerusahaanAsuransi);
            }



            entity.NamaAsuransi = request.NamaAsuransi;
            entity.AlamatAsuransi = request.AlamatAsuransi;
            entity.KelurahanAsuransi = request.KelurahanAsuransi;
            entity.KecamatanAsuransi = request.KecamatanAsuransi;
            entity.KotaAsuransi = request.KotaAsuransi;
            entity.PropinsiAsuransi = request.PropinsiAsuransi;
            entity.KodePosAsuransi = request.KodePosAsuransi;
               entity.TelpAsuransi = request.TelpAsuransi;
            entity.FaxAsuransi = request.FaxAsuransi;
            entity.PihakBerwenang = request.PihakBerwenang;

            _context.MasterPerusahaanAsuransi.Update(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;

        }
    }
}
