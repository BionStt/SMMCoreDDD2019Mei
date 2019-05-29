using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using MediatR;
using SmmCoreDDD2019.Application.Exceptions;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;


namespace SmmCoreDDD2019.Application.DataKonsumenAvalistDbs.Command.CreateDataKonsumenAvalist
{
    public class CreateDataKonsumenAvalistCommandHandler : IRequestHandler<CreateDataKonsumenAvalistCommand>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;
        public CreateDataKonsumenAvalistCommandHandler(ISMMCoreDDD2019DbContext context,
            INotificationService notificationService,
                IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;

        }
        public async Task<Unit> Handle(CreateDataKonsumenAvalistCommand request, CancellationToken cancellationToken)
        {
            var entity = new DataKonsumenAvalist
            {
                NoRegisterKonsumen = DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper() + "REGCUST",

                //TanggalRegister = request.TanggalRegister,
                NamaKonsumen = request.NamaKonsumen,
                AlamatTinggalK = request.AlamatTinggalK,
                KelurahanK = request.KelurahanK,
                KecamatanK = request.KecamatanK,
                KotaK = request.KotaK,
                PropinsiK = request.PropinsiK,
                KodePosTinggalK = request.KodePosTinggalK,
                TelpRumah= request.TelpRumah,
                NoHandphone= request.NoHandphone,
                NoHandphone2 = request.NoHandphone2,
                NoKTP = request.NoKTP,
                TempatLahir = request.TempatLahir,
                Tanggallahir = request.Tanggallahir,
                TanggalExpireKTP = request.TanggalExpireKTP,
                AlamatKTP= request.AlamatKTP,
                KelurahanKTP= request.KelurahanKTP,
                KecamatanKTP= request.KecamatanKTP,
                KotaKTP = request.KotaKTP,
                PropinsiKTP= request.PropinsiKTP,
                KodePosKTP = request.KodePosKTP,
                JenisKelamin= request.JenisKelamin,
                StatusNikah = request.StatusNikah,
                Agama = request.Agama,
                TingkatPendidikan= request.TingkatPendidikan,
                Email= request.Email,
                KodePekerjaan= request.KodePekerjaan,
                NamaPekerjaan = request.NamaPekerjaan,
                JabatanPerusahaan= request.JabatanPerusahaan,
                NamaKantor= request.NamaKantor,
                AlamatKantor= request.AlamatKantor,
                KelurahanKantor= request.KelurahanKantor,
                KecamatanKantor= request.KecamatanKantor,
                KotaKantor= request.KotaKantor,
                PropinsiKantor= request.PropinsiKantor,
            KodePosKantor = request.KodePosKantor,
                TelpKantor = request.TelpKantor,
                FaxKantor= request.FaxKantor,
                NamaUsaha= request.NamaUsaha,
                AlamatUsaha= request.AlamatUsaha,
                KelurahanUsaha = request.KelurahanUsaha,
                KecamatanUsaha= request.KecamatanUsaha,
                KotaUsaha= request.KotaUsaha,
                PropinsiUsaha= request.PropinsiUsaha,
                KodePosUsaha= request.KodePosUsaha,
                TelpUsaha= request.TelpUsaha,
                FaxUsaha= request.FaxUsaha,
                 NoNpwpusaha= request.NoNpwpusaha,
                 NoSiupusaha= request.NoSiupusaha,
                 NoTDPusaha = request.NoTDPusaha,
                TanggalMulaiUsaha = request.TanggalMulaiUsaha,
                JumlahKaryawan= request.JumlahKaryawan,
                 SkalaUsaha= request.SkalaUsaha,
                 KodeBidangUsaha= request.KodeBidangUsaha,
                 NamaBidangUsaha= request.NamaBidangUsaha,
                 AlamatSurat= request.AlamatSurat,
                KelurahanSurat = request.KelurahanSurat,
                KecamatanSurat = request.KecamatanSurat,
                KotaSurat = request.KotaSurat,
               PropinsiSurat= request.PropinsiSurat,
                 KodePosSurat= request.KodePosSurat,
                NamaIbuKandung = request.NamaIbuKandung,
                KodePekerjaanIbuKandung = request.KodePekerjaanIbuKandung,
                NamaPekerjaanIbuKandung = request.NamaPekerjaanIbuKandung,
                KodeBidangUsahaIbuKandung = request.KodeBidangUsahaIbuKandung,
                NamaBidangUsahaIbuKandung = request.NamaBidangUsahaIbuKandung,
                NamaPenjamin = request.NamaPenjamin,
                AlamatPenjamin = request.AlamatPenjamin,
                KelurahanPenjamin = request.KelurahanPenjamin,
                KecamatanPenjamin = request.KecamatanPenjamin,
                KotaPenjamin = request.KotaPenjamin,
                PropinsiPenjamin = request.PropinsiPenjamin,
                KodePosPenjamin = request.KodePosPenjamin,
                TelpRumahPenjamin = request.TelpRumahPenjamin,
                NoHandphonePenjamin = request.NoHandphonePenjamin,
                NoHandphonePenjamin2 = request.NoHandphonePenjamin2,
                NoKTPPenjamin = request.NoKTPPenjamin,
                TempatLahirPenjamin = request.TempatLahirPenjamin,
                TanggalLahirPenjamin = request.TanggalLahirPenjamin,
                TanggalExpireKTPPenjamin = request.TanggalExpireKTPPenjamin,
                AlamatKtpPenjamin = request.AlamatKtpPenjamin,
                KelurahanKtpPenjamin = request.KelurahanKtpPenjamin,
                KecamatanKtpPenjamin = request.KecamatanKtpPenjamin,
                KotaKtpPenjamin = request.KotaKtpPenjamin,
                PropinsiKtpPenjamin = request.PropinsiKtpPenjamin,
                KodePosKTPPenjamin = request.KodePosKTPPenjamin,
                JenisKelaminPenjamin = request.JenisKelaminPenjamin,
                StatusNikahPenjamin = request.StatusNikahPenjamin,
                AgamaPenjamin = request.AgamaPenjamin,
                EmailPenjamin = request.EmailPenjamin,
                KodeBidangUsahaPenjamin = request.KodeBidangUsahaPenjamin,
                NamaBidangUsahaPenjamin = request.NamaBidangUsahaPenjamin,
                KodePekerjaanPenjamin = request.KodePekerjaanPenjamin,
                NamaPekerjaanPenjamin = request.NamaPekerjaanPenjamin,
                TingkatPendidikanPenjamin = request.TingkatPendidikanPenjamin,
                HubunganPenjamin = request.HubunganPenjamin,
                NamaKantorPenjamin = request.NamaKantorPenjamin,
                AlamatKantorPenjamin = request.AlamatKantorPenjamin,
                KelurahanKantorPenjamin= request.KelurahanKantorPenjamin,
                KecamatanKantorPenjamin = request.KecamatanKantorPenjamin,
                KotaKantorPenjamin= request.KotaKantorPenjamin,
                PropinsiKantorPenjamin = request.PropinsiKantorPenjamin,
                KodePosKantorPenjamin = request.KodePosKantorPenjamin,
                TelpKantorPenjamin = request.TelpKantorPenjamin,
                FaxKantorPenjamin= request.FaxKantorPenjamin,
                NamaUsahaPenjamin = request.NamaUsahaPenjamin,
                AlamatUsahaPenjamin = request.AlamatUsahaPenjamin,
                KelurahanUsahaPenjamin = request.KelurahanUsahaPenjamin,
                KecamatanUsahaPenjamin = request.KecamatanUsahaPenjamin,
                KotaUsahaPenjamin = request.KotaUsahaPenjamin,
                PropinsiUsahaPenjamin = request.PropinsiUsahaPenjamin,
                KodePosUsahaPenjamin = request.KodePosUsahaPenjamin,
                TelpUsahaPenjamin = request.TelpUsahaPenjamin,
                FaxUsahaPenjamin = request.FaxUsahaPenjamin,
                NoNPWPUsahaPenjamin = request.NoNPWPUsahaPenjamin,
                NoTDPUsahaPenjamin = request.NoTDPUsahaPenjamin,
                NoSIUPusahaPenjamin = request.NoSIUPusahaPenjamin,
                JmlKaryawanPenjamin = request.JmlKaryawanPenjamin,
                SkalaUsahaPenjamin = request.SkalaUsahaPenjamin




            };

            _context.DataKonsumenAvalist.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            await _mediator.Publish(new DataKonsumenAvalistCreated { DataKonsumenAvalistID = entity.NoUrutKonsumen },cancellationToken);
            return Unit.Value;
        }
    }
}
