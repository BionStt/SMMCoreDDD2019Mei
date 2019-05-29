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
using SmmCoreDDD2019.Application.Interfaces;

namespace SmmCoreDDD2019.Application.DataKontrakSurveiDBs.Command.UpdateDataKontrakSurvei
{
    public class UpdateDataKontrakSurveiCommandHandler : IRequestHandler<UpdateDataKontrakSurveiCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;

        public UpdateDataKontrakSurveiCommandHandler(ISMMCoreDDD2019DbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(UpdateDataKontrakSurveiCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.DataKontrakSurvei
              .SingleAsync(c => c.NoUrutDataSurvei == request.NoUrutDataSurvei, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(DataKontrakSurvei), request.NoUrutDataSurvei);
            }

            entity.NoRegistrasiDataSurvei = request.NoRegistrasiDataSurvei;
              entity.NoRegistrasiKonsumen = request.NoRegistrasiKonsumen;
                entity.Karakter = request.Karakter;
                entity.Kerjasama = request.Kerjasama;
               entity.Penghasilan = request.Penghasilan;
               entity.Penghasilanlain = request.Penghasilanlain;
               entity.PenghasilanPasangan = request.PenghasilanPasangan;
               entity.PengeluaranTetapBulanan = request.PengeluaranTetapBulanan;
              entity.Tanggungan = request.Tanggungan;
               entity.StatusTempatTinggal = request.StatusTempatTinggal;
               entity.TinggalSejak = request.TinggalSejak;
               entity.HasilSurvei = request.HasilSurvei;
               entity.KodeBidangPekerjaan = request.KodeBidangPekerjaan;
               entity.NamaBidangPekerjaan = request.NamaBidangPekerjaan;
               entity.KodeBidangUsaha = request.KodeBidangUsaha;
              entity.NamaBidangUsaha = request.NamaBidangUsaha;
              entity.OmzetBulanan = request.OmzetBulanan;
               entity.PernahKredit = request.PernahKredit;
               entity.NoUrutMasterBarang = request.NoUrutMasterBarang;
               entity.FasilitasKreditBank = request.FasilitasKreditBank;
               entity.JenisFasilitasbank = request.JenisFasilitasbank;
               entity.NamaRekeningBank = request.NamaRekeningBank;
               entity.NoRekeningBank = request.NoRekeningBank;
               entity.LuasRumah = request.LuasRumah;
               entity.LuasTanah = request.LuasTanah;
               entity.LuasUsaha = request.LuasUsaha;
               entity.DayaListrikRumah = request.DayaListrikRumah;
              entity.TagihanPLN = request.TagihanPLN;
               entity.TagihanPDAM = request.TagihanPDAM;
               entity.TagihanTelp = request.TagihanTelp;
               entity.KondisiFisikRumah = request.KondisiFisikRumah;
               entity.SegmenRumah = request.SegmenRumah;
               entity.KondisiJalanRumah = request.KondisiJalanRumah;
               entity.PagarRumah = request.PagarRumah;
               entity.TamanRumah = request.TamanRumah;
               entity.GarasiRumah = request.GarasiRumah;
              entity.KapasitasGarasiRumah = request.KapasitasGarasiRumah;
               entity.DindingRumah = request.DindingRumah;
               entity.AtapRumah = request.AtapRumah;
               entity.LantaiRumah = request.LantaiRumah;
               entity.ToiletRumah = request.ToiletRumah;
               entity.TelevisiRumah = request.TelevisiRumah;
               entity.Kulkas = request.Kulkas;
               entity.LokasiSurvei = request.LokasiSurvei;
                entity.LokasiTempatTinggal = request.LokasiTempatTinggal;
               entity.NamaMendesak = request.NamaMendesak;
               entity.AlamatMendesak = request.AlamatMendesak;
               entity.KelurahanMendesak = request.KelurahanMendesak;
               entity.KecamatanMendesak = request.KecamatanMendesak;
               entity.KotaMendesak = request.KotaMendesak;
               entity.PropinsiMendesak = request.PropinsiMendesak;
               entity.KodePosMendesak = request.KodePosMendesak;
               entity.TelpMendesak = request.TelpMendesak;
               entity.HandphoneMendesak = request.HandphoneMendesak;
               entity.HandphoneMendesak2 = request.HandphoneMendesak2;
               entity.HubunganDenganMendesak = request.HubunganDenganMendesak;
               entity.SurveiId = request.SurveiId;
               entity.KeteranganLain = request.KeteranganLain;


            _context.DataKontrakSurvei.Update(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;


        }
    }
}
