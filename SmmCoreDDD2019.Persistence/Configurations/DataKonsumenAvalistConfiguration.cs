using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Persistence.Configurations
{
    public class DataKonsumenAvalistConfiguration : IEntityTypeConfiguration<DataKonsumenAvalist>
    {
        public void Configure(EntityTypeBuilder<DataKonsumenAvalist> builder)
        {
            builder.ToTable("DataKonsumenAvalist", "DataAvalist");

           builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("DataKonsumenAvalist_hilo").IsRequired();
           builder.Property(e => e.NoRegisterKonsumen).HasMaxLength(50)
            .IsUnicode(false);

            builder.Property(e => e.TanggalRegister).HasColumnType("datetime").HasDefaultValueSql("(getdate())");

            builder.Property(e => e.NamaKonsumen).HasMaxLength(50)
           .IsUnicode(false);

            builder.Property(e => e.AlamatTinggalK).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KelurahanK).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KecamatanK).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KotaK).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.PropinsiK).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KodePosTinggalK).HasMaxLength(8).IsUnicode(false);
            builder.Property(e => e.TelpRumah).HasMaxLength(25).IsUnicode(false);
            builder.Property(e => e.NoHandphone).HasMaxLength(25).IsUnicode(false);
            builder.Property(e => e.NoHandphone2).HasMaxLength(25).IsUnicode(false);
            builder.Property(e => e.NoKTP).HasMaxLength(30).IsUnicode(false);
            builder.Property(e => e.TempatLahir).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.Tanggallahir).HasColumnType("datetime");
            builder.Property(e => e.TanggalExpireKTP).HasColumnType("datetime");
            builder.Property(e => e.AlamatKTP).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KelurahanKTP).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KecamatanKTP).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KotaKTP).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.PropinsiKTP).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KodePosKTP).HasMaxLength(8).IsUnicode(false);
            builder.Property(e => e.JenisKelamin).HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.StatusNikah).HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.Agama).HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.TingkatPendidikan).HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.Email).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KodePekerjaan).HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.NamaPekerjaan).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.JabatanPerusahaan).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.NamaKantor).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.AlamatKantor).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KelurahanKantor).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KecamatanKantor).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KotaKantor).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.PropinsiKantor).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KodePosKantor).HasMaxLength(8).IsUnicode(false);
            builder.Property(e => e.TelpKantor).HasMaxLength(20).IsUnicode(false);
            builder.Property(e => e.FaxKantor).HasMaxLength(20).IsUnicode(false);
            builder.Property(e => e.NamaUsaha).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.AlamatUsaha).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KelurahanUsaha).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KecamatanUsaha).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KotaUsaha).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.PropinsiUsaha).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KodePosUsaha).HasMaxLength(8).IsUnicode(false);
            builder.Property(e => e.TelpUsaha).HasMaxLength(20).IsUnicode(false);
            builder.Property(e => e.FaxUsaha).HasMaxLength(20).IsUnicode(false);
            builder.Property(e => e.NoNpwpusaha).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.NoSiupusaha).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.NoTDPusaha).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.TanggalMulaiUsaha).HasColumnType("datetime");
            builder.Property(e => e.JumlahKaryawan).HasMaxLength(4).IsUnicode(false);
            builder.Property(e => e.SkalaUsaha).HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.KodeBidangUsaha).HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.NamaBidangUsaha).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.AlamatSurat).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KelurahanSurat).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KecamatanSurat).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KotaSurat).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.PropinsiSurat).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KodePosSurat).HasMaxLength(8).IsUnicode(false);
            builder.Property(e => e.NamaIbuKandung).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KodePekerjaanIbuKandung).HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.NamaPekerjaanIbuKandung).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KodeBidangUsahaIbuKandung).HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.NamaBidangUsahaIbuKandung).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.NamaPenjamin).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.AlamatPenjamin).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KelurahanPenjamin).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KecamatanPenjamin).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KotaPenjamin).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.PropinsiPenjamin).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KodePosPenjamin).HasMaxLength(8).IsUnicode(false);
            builder.Property(e => e.TelpRumahPenjamin).HasMaxLength(20).IsUnicode(false);
            builder.Property(e => e.NoHandphonePenjamin).HasMaxLength(20).IsUnicode(false);
            builder.Property(e => e.NoHandphonePenjamin2).HasMaxLength(20).IsUnicode(false);
            builder.Property(e => e.NoKTPPenjamin).HasMaxLength(30).IsUnicode(false);
            builder.Property(e => e.TempatLahirPenjamin).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.TanggalLahirPenjamin).HasColumnType("datetime");
            builder.Property(e => e.TanggalExpireKTPPenjamin).HasColumnType("datetime");
            builder.Property(e => e.AlamatKtpPenjamin).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KelurahanKtpPenjamin).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KecamatanKtpPenjamin).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KotaKtpPenjamin).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.PropinsiKtpPenjamin).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KodePosKTPPenjamin).HasMaxLength(8).IsUnicode(false);
            builder.Property(e => e.JenisKelaminPenjamin).HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.StatusNikahPenjamin).HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.AgamaPenjamin).HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.EmailPenjamin).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KodeBidangUsahaPenjamin).HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.NamaBidangUsahaPenjamin).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KodePekerjaanPenjamin).HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.NamaPekerjaanPenjamin).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.TingkatPendidikanPenjamin).HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.HubunganPenjamin).HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.NamaKantorPenjamin).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.AlamatKantorPenjamin).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KelurahanKantorPenjamin).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KecamatanKantorPenjamin).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KotaKantorPenjamin).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.PropinsiKantorPenjamin).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KodePosKantorPenjamin).HasMaxLength(8).IsUnicode(false);
            builder.Property(e => e.TelpKantorPenjamin).HasMaxLength(20).IsUnicode(false);
            builder.Property(e => e.FaxKantorPenjamin).HasMaxLength(20).IsUnicode(false);
            builder.Property(e => e.NamaUsahaPenjamin).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.AlamatUsahaPenjamin).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KelurahanUsahaPenjamin).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KecamatanUsahaPenjamin).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KotaUsahaPenjamin).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.PropinsiUsahaPenjamin).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KodePosUsahaPenjamin).HasMaxLength(8).IsUnicode(false);
            builder.Property(e => e.TelpUsahaPenjamin).HasMaxLength(20).IsUnicode(false);
            builder.Property(e => e.FaxUsahaPenjamin).HasMaxLength(20).IsUnicode(false);
            builder.Property(e => e.NoNPWPUsahaPenjamin).HasMaxLength(40).IsUnicode(false);
            builder.Property(e => e.NoSIUPusahaPenjamin).HasMaxLength(40).IsUnicode(false);
            builder.Property(e => e.NoTDPUsahaPenjamin).HasMaxLength(40).IsUnicode(false);
            builder.Property(e => e.JmlKaryawanPenjamin).HasMaxLength(4).IsUnicode(false);
            builder.Property(e => e.SkalaUsahaPenjamin).HasMaxLength(2).IsUnicode(false);

        }
    }
}
