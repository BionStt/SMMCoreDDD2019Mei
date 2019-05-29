using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Application.DataKontrakSurveiDBs.Command.CreateDataKontrakSurvei
{
    public class CreateDataKontrakSurveiCommandHandler : IRequestHandler<CreateDataKontrakSurveiCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;

        public CreateDataKontrakSurveiCommandHandler(
            ISMMCoreDDD2019DbContext context,
            INotificationService notificationService,
            IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;
        }
        public async Task<Unit> Handle(CreateDataKontrakSurveiCommand request, CancellationToken cancellationToken)
        {
            var entity = new DataKontrakSurvei
            {
                 NoRegistrasiDataSurvei = DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper() + "REGDS",

              NoRegistrasiKonsumen = request.NoRegistrasiKonsumen,
                Karakter= request.Karakter,
                Kerjasama= request.Kerjasama,
                Penghasilan = request.Penghasilan,
                Penghasilanlain = request.Penghasilanlain,
                PenghasilanPasangan = request.PenghasilanPasangan,
                PengeluaranTetapBulanan = request.PengeluaranTetapBulanan,
                Tanggungan = request.Tanggungan,
                StatusTempatTinggal=request.StatusTempatTinggal,
                TinggalSejak=request.TinggalSejak,
                HasilSurvei=request.HasilSurvei,
                KodeBidangPekerjaan=request.KodeBidangPekerjaan,
                NamaBidangPekerjaan=request.NamaBidangPekerjaan,
                KodeBidangUsaha=request.KodeBidangUsaha,
                NamaBidangUsaha=request.NamaBidangUsaha,
                OmzetBulanan=request.OmzetBulanan,
                PernahKredit=request.PernahKredit,
                NoUrutMasterBarang=request.NoUrutMasterBarang,
                FasilitasKreditBank=request.FasilitasKreditBank,
                JenisFasilitasbank=request.JenisFasilitasbank,
                NamaRekeningBank=request.NamaRekeningBank,
                NoRekeningBank=request.NoRekeningBank,
                LuasRumah=request.LuasRumah,
                LuasTanah=request.LuasTanah,
                LuasUsaha=request.LuasUsaha,
                DayaListrikRumah=request.DayaListrikRumah,
                TagihanPLN=request.TagihanPLN,
                TagihanPDAM=request.TagihanPDAM,
                TagihanTelp=request.TagihanTelp,
                KondisiFisikRumah=request.KondisiFisikRumah,
                SegmenRumah=request.SegmenRumah,
                KondisiJalanRumah=request.KondisiJalanRumah,
                PagarRumah=request.PagarRumah,
                TamanRumah=request.TamanRumah,
                GarasiRumah=request.GarasiRumah,
                KapasitasGarasiRumah=request.KapasitasGarasiRumah,
                DindingRumah=request.DindingRumah,
                AtapRumah=request.AtapRumah,
                LantaiRumah=request.LantaiRumah,
                ToiletRumah=request.ToiletRumah,
                TelevisiRumah=request.TelevisiRumah,
                Kulkas=request.Kulkas,
                LokasiSurvei=request.LokasiSurvei,
                LokasiTempatTinggal=request.LokasiTempatTinggal,
                NamaMendesak=request.NamaMendesak,
                AlamatMendesak=request.AlamatMendesak,
                KelurahanMendesak=request.KelurahanMendesak,
                KecamatanMendesak=request.KecamatanMendesak,
                KotaMendesak=request.KotaMendesak,
                PropinsiMendesak=request.PropinsiMendesak,
                KodePosMendesak=request.KodePosMendesak,
                TelpMendesak=request.TelpMendesak,
                HandphoneMendesak=request.HandphoneMendesak,
                HandphoneMendesak2=request.HandphoneMendesak2,
                HubunganDenganMendesak=request.HubunganDenganMendesak,
                SurveiId=request.SurveiId,
                KeteranganLain=request.KeteranganLain





            };

            _context.DataKontrakSurvei.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            await _mediator.Publish(new DataKontrakSurveiCreated { DataKontrakSurveiID = entity.NoUrutDataSurvei.ToString() });

            return Unit.Value;

        }
    }
}
