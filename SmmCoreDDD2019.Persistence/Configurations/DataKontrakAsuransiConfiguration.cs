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
    public class DataKontrakAsuransiConfiguration : IEntityTypeConfiguration<DataKontrakAsuransi>
    {
        public void Configure(EntityTypeBuilder<DataKontrakAsuransi> builder)
        {
            builder.ToTable("DataKontrakAsuransi", "DataAvalist");

            builder.HasKey(e => e.NoUrutDataAsuransi);
            builder.Property(e => e.NoUrutDataAsuransi).HasColumnName("NoUrutDataAsuransi");
            builder.Property(e => e.NoUrutDataAsuransi).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;
            builder.Property(e => e.NoRegistrasiKontrakAsuransi).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.NoRegistrasiKontrakKredit).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KodeAsuransi).HasMaxLength(5).IsUnicode(false);
            builder.Property(e => e.JenisAsuransi).HasMaxLength(5).IsUnicode(false);
            builder.Property(e => e.TanggalMulaiAsuransi).HasColumnType("datetime");
            builder.Property(e => e.TanggalAkhirAsuransi).HasColumnType("datetime");
            builder.Property(e => e.LamaAsuransi).HasMaxLength(4).IsUnicode(false);
            builder.Property(e => e.NilaiPertanggungan).HasColumnType("money");
            builder.Property(e => e.BiayaAsuransi).HasColumnType("money");

          
        }
    }
}
