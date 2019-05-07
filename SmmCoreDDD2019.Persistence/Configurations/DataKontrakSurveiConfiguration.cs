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
    public class DataKontrakSurveiConfiguration : IEntityTypeConfiguration<DataKontrakSurvei>
    {
        public void Configure(EntityTypeBuilder<DataKontrakSurvei> builder)
        {
            builder.ToTable("DataKontrakSurvei", "DataAvalist");

            builder.HasKey(e => e.NoUrutDataSurvei);
            builder.Property(e => e.NoUrutDataSurvei).HasColumnName("NoUrutDataSurvei");
            builder.Property(e => e.NoUrutDataSurvei).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;

            builder.Property(e => e.NoRegistrasiDataSurvei).HasMaxLength(30).IsUnicode(false);

            builder.Property(e => e.TanggalSurvei).HasColumnType("datetime").HasDefaultValueSql("(getdate())");

            builder.Property(e => e.NoRegistrasiKonsumen).HasMaxLength(30).IsUnicode(false);
            builder.Property(e => e.Karakter).HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.Kerjasama).HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.Penghasilan).HasColumnType("money");
            builder.Property(e => e.Penghasilanlain).HasColumnType("money");
            builder.Property(e => e.PenghasilanPasangan).HasColumnType("money");

            builder.Property(e => e.PengeluaranTetapBulanan).HasColumnType("money");

            builder.Property(e => e.Tanggungan).HasMaxLength(4).IsUnicode(false);
            builder.Property(e => e.StatusTempatTinggal).HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.TinggalSejak).HasMaxLength(3).IsUnicode(false);
            builder.Property(e => e.HasilSurvei).HasMaxLength(1).IsUnicode(false);
            builder.Property(e => e.KodeBidangPekerjaan).HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.NamaBidangPekerjaan).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KodeBidangUsaha).HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.NamaBidangUsaha).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.OmzetBulanan).HasColumnType("money");
            builder.Property(e => e.PernahKredit).HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.NoUrutMasterBarang).HasMaxLength(4).IsUnicode(false);
            builder.Property(e => e.FasilitasKreditBank).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.JenisFasilitasbank).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.NamaRekeningBank).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.NoRekeningBank).HasMaxLength(30).IsUnicode(false);
            builder.Property(e => e.LuasRumah).HasMaxLength(30).IsUnicode(false);
            builder.Property(e => e.LuasTanah).HasMaxLength(30).IsUnicode(false);
            builder.Property(e => e.LuasUsaha).HasMaxLength(30).IsUnicode(false);
            builder.Property(e => e.DayaListrikRumah).HasMaxLength(10).IsUnicode(false);
            builder.Property(e => e.TagihanPLN).HasColumnType("money");
            builder.Property(e => e.TagihanPDAM).HasColumnType("money");
            builder.Property(e => e.TagihanTelp).HasColumnType("money");
            builder.Property(e => e.KondisiFisikRumah).HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.KondisiJalanRumah).HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.SegmenRumah).HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.PagarRumah).HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.TamanRumah).HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.GarasiRumah).HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.KapasitasGarasiRumah).HasMaxLength(30).IsUnicode(false);
            builder.Property(e => e.DindingRumah).HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.AtapRumah).HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.LantaiRumah).HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.ToiletRumah).HasMaxLength(1).IsUnicode(false);
            builder.Property(e => e.TelevisiRumah).HasMaxLength(1).IsUnicode(false);
            builder.Property(e => e.Kulkas).HasMaxLength(1).IsUnicode(false);
            builder.Property(e => e.LokasiSurvei).HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.LokasiTempatTinggal).HasMaxLength(1).IsUnicode(false);
            builder.Property(e => e.NamaMendesak).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.AlamatMendesak).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KelurahanMendesak).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KecamatanMendesak).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KotaMendesak).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.PropinsiMendesak).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KodePosMendesak).HasMaxLength(8).IsUnicode(false);
            builder.Property(e => e.TelpMendesak).HasMaxLength(20).IsUnicode(false);
            builder.Property(e => e.HandphoneMendesak).HasMaxLength(20).IsUnicode(false);
            builder.Property(e => e.HandphoneMendesak2).HasMaxLength(20).IsUnicode(false);
            builder.Property(e => e.HubunganDenganMendesak).HasMaxLength(1).IsUnicode(false);
            builder.Property(e => e.SurveiId).HasMaxLength(3).IsUnicode(false);
            builder.Property(e => e.KeteranganLain).HasMaxLength(300).IsUnicode(false);




        }
    }
}
