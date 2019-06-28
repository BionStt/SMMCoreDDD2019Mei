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
    public class DataKontrakKreditConfiguration : IEntityTypeConfiguration<DataKontrakKredit>
    {
        public void Configure(EntityTypeBuilder<DataKontrakKredit> builder)
        {
            builder.ToTable("DataKontrakKredit", "DataAvalist");

            builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("DataKontrakKredit_hilo").IsRequired();

            builder.Property(e => e.NoRegisterKontrakKredit).HasMaxLength(30).IsUnicode(false);
            builder.Property(e => e.DataKontrakSurveiId);
            builder.Property(e => e.TanggalKontrak).HasColumnType("datetime");
            builder.Property(e => e.PolaAngsuran).HasMaxLength(3).IsUnicode(false);
            builder.Property(e => e.CaraBayar).HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.HargaBarang).HasColumnType("money");
            builder.Property(e => e.PinjamanPokok).HasColumnType("money");
            builder.Property(e => e.UangMuka).HasColumnType("money");
            builder.Property(e => e.Asuransi).HasColumnType("money");
            builder.Property(e => e.Administrasi).HasColumnType("money");
            builder.Property(e => e.BungaEff).HasColumnType("decimal(8, 5)");
            builder.Property(e => e.BungaFlat).HasColumnType("decimal(8, 5)");
            builder.Property(e => e.LamaKredit).HasMaxLength(30).IsUnicode(false);
            builder.Property(e => e.TanggalAngsuranBulanan).HasMaxLength(3);
            builder.Property(e => e.AngsuranDimuka).HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.NilaiBunga).HasColumnType("money");
            builder.Property(e => e.NilaiKontrak).HasColumnType("money");
         
            builder.Property(e => e.AngsuranBulanan).HasColumnType("money");
            builder.Property(e => e.BiayaAdministrasiAngsuran).HasColumnType("money");
            builder.Property(e => e.PenagihId).HasMaxLength(2).IsUnicode(false);

        }
    }
}
