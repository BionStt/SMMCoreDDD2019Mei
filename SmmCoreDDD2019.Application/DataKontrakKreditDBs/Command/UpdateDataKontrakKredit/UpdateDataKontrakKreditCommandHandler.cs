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
namespace SmmCoreDDD2019.Application.DataKontrakKreditDBs.Command.UpdateDataKontrakKredit
{
    public class UpdateDataKontrakKreditCommandHandler : IRequestHandler<UpdateDataKontrakKreditCommand, Unit>
    {
        private readonly SMMCoreDDD2019DbContext _context;

        public UpdateDataKontrakKreditCommandHandler(SMMCoreDDD2019DbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateDataKontrakKreditCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.DataKontrakKredit
               .SingleAsync(c => c.NoUrutDataKontrakKredit == request.NoUrutDataKontrakKredit, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(DataKontrakKredit), request.NoUrutDataKontrakKredit);
            }

            entity.NoRegisterKontrakKredit = request.NoRegisterKontrakKredit;
            entity.NoRegisterSurvei = request.NoRegisterSurvei;
                entity.TanggalKontrak = request.TanggalKontrak;
              entity.PolaAngsuran = request.PolaAngsuran;
              entity.CaraBayar = request.CaraBayar;
               entity.HargaBarang = request.HargaBarang;
               entity.UangMuka = request.UangMuka;
               entity.Asuransi = request.Asuransi;
              entity.Administrasi = request.Administrasi;
               entity.BungaEff = request.BungaEff;
               entity.BungaFlat = request.BungaFlat;
               entity.LamaKredit = request.LamaKredit;
               entity.TanggalAngsuranBulanan = request.TanggalAngsuranBulanan;
               entity.AngsuranDimuka = request.AngsuranDimuka;
               entity.NilaiBunga = request.NilaiBunga;
               entity.NilaiKontrak = request.NilaiKontrak;
               entity.AngsuranBulanan = request.AngsuranBulanan;
               entity.BiayaAdministrasiAngsuran = request.BiayaAdministrasiAngsuran;
               entity.PenagihId = request.PenagihId;


            _context.DataKontrakKredit.Update(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
