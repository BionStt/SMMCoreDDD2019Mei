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
namespace SmmCoreDDD2019.Application.DataKonsumenAvalistDbs.Command.UpdateDataKonsumenAvalist
{
    public class UpdateDataKonsumenAvalistCommandHandler : IRequestHandler<UpdateDataKonsumenAvalistCommand, Unit>
    {
        private readonly SMMCoreDDD2019DbContext _context;

        public UpdateDataKonsumenAvalistCommandHandler(SMMCoreDDD2019DbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(UpdateDataKonsumenAvalistCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.DataKonsumenAvalist
                .SingleAsync(c => c.NoUrutKonsumen == request.NoUrutKonsumen, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(DataKonsumenAvalist), request.NoUrutKonsumen);
            }

           entity.NoRegisterKonsumen = request.NoRegisterKonsumen;
                entity.TanggalRegister = request.TanggalRegister;
                entity.NamaKonsumen = request.NamaKonsumen;
                entity.AlamatTinggalK = request.AlamatTinggalK;
                entity.KelurahanK = request.KelurahanK;
                entity.KecamatanK = request.KecamatanK;
                entity.KotaK = request.KotaK;
                entity.PropinsiK = request.PropinsiK;
                entity.KodePosTinggalK = request.KodePosTinggalK;
               entity.TelpRumah = request.TelpRumah;
               entity.NoHandphone = request.NoHandphone;
               entity.NoHandphone2 = request.NoHandphone2;
               entity.NoKTP = request.NoKTP;
               entity.TempatLahir = request.TempatLahir;
               entity.Tanggallahir = request.Tanggallahir;
                entity.TanggalExpireKTP = request.TanggalExpireKTP;
                entity.AlamatKTP = request.AlamatKTP;
                entity.KelurahanKTP = request.KelurahanKTP;
               entity.KecamatanKTP = request.KecamatanKTP;
               entity.KotaKTP = request.KotaKTP;
               entity.PropinsiKTP = request.PropinsiKTP;
               entity.KodePosKTP = request.KodePosKTP;
              entity.JenisKelamin = request.JenisKelamin;
               entity.StatusNikah = request.StatusNikah;
               entity.Agama = request.Agama;
               entity.TingkatPendidikan = request.TingkatPendidikan;
               entity.Email = request.Email;
               entity.KodePekerjaan = request.KodePekerjaan;
               entity.NamaPekerjaan = request.NamaPekerjaan;
               entity.JabatanPerusahaan = request.JabatanPerusahaan;
               entity.NamaKantor = request.NamaKantor;
               entity.AlamatKantor = request.AlamatKantor;
               entity.KelurahanKantor = request.KelurahanKantor;
               entity.KecamatanKantor = request.KecamatanKantor;
              entity.KotaKantor = request.KotaKantor;
               entity.PropinsiKantor = request.PropinsiKantor;
           entity.KodePosKantor = request.KodePosKantor;
               entity.TelpKantor = request.TelpKantor;
               entity.FaxKantor = request.FaxKantor;
               entity.NamaUsaha = request.NamaUsaha;
               entity.AlamatUsaha = request.AlamatUsaha;
               entity.KelurahanUsaha = request.KelurahanUsaha;
               entity.KecamatanUsaha = request.KecamatanUsaha;
               entity.KotaUsaha = request.KotaUsaha;
                entity.PropinsiUsaha = request.PropinsiUsaha;
               entity.KodePosUsaha = request.KodePosUsaha;
               entity.TelpUsaha = request.TelpUsaha;
               entity.FaxUsaha = request.FaxUsaha;
               entity.NoNpwpusaha = request.NoNpwpusaha;
                entity.NoSiupusaha = request.NoSiupusaha;
                entity.NoTDPusaha = request.NoTDPusaha;
                entity.TanggalMulaiUsaha = request.TanggalMulaiUsaha;
               entity.JumlahKaryawan = request.JumlahKaryawan;
               entity.SkalaUsaha = request.SkalaUsaha;
               entity.KodeBidangUsaha = request.KodeBidangUsaha;
               entity.NamaBidangUsaha = request.NamaBidangUsaha;
               entity.AlamatSurat = request.AlamatSurat;
               entity.KelurahanSurat = request.KelurahanSurat;
               entity.KecamatanSurat = request.KecamatanSurat;
               entity.KotaSurat = request.KotaSurat;
               entity.PropinsiSurat = request.PropinsiSurat;
               entity.KodePosSurat = request.KodePosSurat;
               entity.NamaIbuKandung = request.NamaIbuKandung;
               entity.KodePekerjaanIbuKandung = request.KodePekerjaanIbuKandung;
               entity.NamaPekerjaanIbuKandung = request.NamaPekerjaanIbuKandung;
               entity.KodeBidangUsahaIbuKandung = request.KodeBidangUsahaIbuKandung;
               entity.NamaBidangUsahaIbuKandung = request.NamaBidangUsahaIbuKandung;
               entity.NamaPenjamin = request.NamaPenjamin;
               entity.AlamatPenjamin = request.AlamatPenjamin;
              entity.KelurahanPenjamin = request.KelurahanPenjamin;
               entity.KecamatanPenjamin = request.KecamatanPenjamin;
              entity.KotaPenjamin = request.KotaPenjamin;
              entity.PropinsiPenjamin = request.PropinsiPenjamin;
              entity.KodePosPenjamin = request.KodePosPenjamin;
              entity.TelpRumahPenjamin = request.TelpRumahPenjamin;
              entity.NoHandphonePenjamin = request.NoHandphonePenjamin;
              entity.NoHandphonePenjamin2 = request.NoHandphonePenjamin2;
               entity.NoKTPPenjamin = request.NoKTPPenjamin;
               entity.TempatLahirPenjamin = request.TempatLahirPenjamin;
               entity.TanggalLahirPenjamin = request.TanggalLahirPenjamin;
               entity.TanggalExpireKTPPenjamin = request.TanggalExpireKTPPenjamin;
               entity.AlamatKtpPenjamin = request.AlamatKtpPenjamin;
               entity.KelurahanKtpPenjamin = request.KelurahanKtpPenjamin;
               entity.KecamatanKtpPenjamin = request.KecamatanKtpPenjamin;
               entity.KotaKtpPenjamin = request.KotaKtpPenjamin;
               entity.PropinsiKtpPenjamin = request.PropinsiKtpPenjamin;
              entity.KodePosKTPPenjamin = request.KodePosKTPPenjamin;
               entity.JenisKelaminPenjamin = request.JenisKelaminPenjamin;
               entity.StatusNikahPenjamin = request.StatusNikahPenjamin;
               entity.AgamaPenjamin = request.AgamaPenjamin;
               entity.EmailPenjamin = request.EmailPenjamin;
               entity.KodeBidangUsahaPenjamin = request.KodeBidangUsahaPenjamin;
               entity.NamaBidangUsahaPenjamin = request.NamaBidangUsahaPenjamin;
               entity.KodePekerjaanPenjamin = request.KodePekerjaanPenjamin;
               entity.NamaPekerjaanPenjamin = request.NamaPekerjaanPenjamin;
              entity.TingkatPendidikanPenjamin = request.TingkatPendidikanPenjamin;
              entity.HubunganPenjamin = request.HubunganPenjamin;
              entity.NamaKantorPenjamin = request.NamaKantorPenjamin;
              entity.AlamatKantorPenjamin = request.AlamatKantorPenjamin;
               entity.KelurahanKantorPenjamin = request.KelurahanKantorPenjamin;
                entity.KecamatanKantorPenjamin = request.KecamatanKantorPenjamin;
               entity.KotaKantorPenjamin = request.KotaKantorPenjamin;
               entity.PropinsiKantorPenjamin = request.PropinsiKantorPenjamin;
               entity.KodePosKantorPenjamin = request.KodePosKantorPenjamin;
               entity.TelpKantorPenjamin = request.TelpKantorPenjamin;
               entity.FaxKantorPenjamin = request.FaxKantorPenjamin;
               entity.NamaUsahaPenjamin = request.NamaUsahaPenjamin;
               entity.AlamatUsahaPenjamin = request.AlamatUsahaPenjamin;
               entity.KelurahanUsahaPenjamin = request.KelurahanUsahaPenjamin;
               entity.KecamatanUsahaPenjamin = request.KecamatanUsahaPenjamin;
               entity.KotaUsahaPenjamin = request.KotaUsahaPenjamin;
              entity.PropinsiUsahaPenjamin = request.PropinsiUsahaPenjamin;
               entity.KodePosUsahaPenjamin = request.KodePosUsahaPenjamin;
              entity.TelpUsahaPenjamin = request.TelpUsahaPenjamin;
              entity.FaxUsahaPenjamin = request.FaxUsahaPenjamin;
              entity.NoNPWPUsahaPenjamin = request.NoNPWPUsahaPenjamin;
               entity.NoTDPUsahaPenjamin = request.NoTDPUsahaPenjamin;
               entity.NoSIUPusahaPenjamin = request.NoSIUPusahaPenjamin;
               entity.JmlKaryawanPenjamin = request.JmlKaryawanPenjamin;
            entity.SkalaUsahaPenjamin = request.SkalaUsahaPenjamin;

            _context.DataKonsumenAvalist.Update(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
