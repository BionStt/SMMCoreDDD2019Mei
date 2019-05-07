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
namespace SmmCoreDDD2019.Application.DataKontrakAngsuranDBs.Command.UpdateDataKontrakAngsuran
{
    public class UpdateDataKontrakAngsuranCommandHandler : IRequestHandler<UpdateDataKontrakAngsuranCommand, Unit>
    {
        private readonly SMMCoreDDD2019DbContext _context;

        public UpdateDataKontrakAngsuranCommandHandler(SMMCoreDDD2019DbContext context)
        {
            _context = context;
        }

        public  async Task<Unit> Handle(UpdateDataKontrakAngsuranCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.DataKontrakAngsuran
               .SingleAsync(c => c.NoUrutDataAngsuran == request.NoUrutDataAngsuran, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(DataKontrakAngsuran), request.NoUrutDataAngsuran);
            }

            entity.NoRegisterKontrakKredit = request.NoRegisterKontrakKredit;
                entity.AngsuranKe = request.AngsuranKe;
                entity.NoKwitansi = request.NoKwitansi;
                entity.TanggalAngsuran = request.TanggalAngsuran;
                entity.Angsuran = request.Angsuran;
                entity.Pokok = request.Pokok;
                entity.Bunga = request.Bunga;
                entity.SisaPokok = request.SisaPokok;
                entity.SisaBunga = request.SisaBunga;
                entity.Denda = request.Denda;
                entity.DiskonDenda = request.DiskonDenda;
                entity.TitipanAngsuran = request.TitipanAngsuran;
                entity.TanggalBayarAngsuran = request.TanggalBayarAngsuran;
                entity.JumlahPembayaran = request.JumlahPembayaran;
                entity.CaraBayar = request.CaraBayar;
                entity.BiayaAdministrasi = request.BiayaAdministrasi;
                entity.PenagihId = request.PenagihId;


            _context.DataKontrakAngsuran.Update(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
