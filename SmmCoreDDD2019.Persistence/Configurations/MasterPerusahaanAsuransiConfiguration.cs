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
    public class MasterPerusahaanAsuransiConfiguration : IEntityTypeConfiguration<MasterPerusahaanAsuransi>
    {
       
        public void Configure(EntityTypeBuilder<MasterPerusahaanAsuransi> builder)
        {
            builder.ToTable("MasterPerusahaanAsuransi", "DataAvalist");

            builder.HasKey(e => e.NoUrutPerusahaanAsuransi);
            builder.Property(e => e.NoUrutPerusahaanAsuransi).HasColumnName("NoUrutPerusahaanAsuransi");
            builder.Property(e => e.NoUrutPerusahaanAsuransi).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;
            builder.Property(e => e.KodeAsuransi).HasMaxLength(5).IsUnicode(false);
            builder.Property(e => e.NamaAsuransi).HasMaxLength(100).IsUnicode(false);

            builder.Property(e => e.AlamatAsuransi).HasMaxLength(100).IsUnicode(false);
            builder.Property(e => e.KelurahanAsuransi).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KecamatanAsuransi).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KotaAsuransi).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.PropinsiAsuransi).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KodePosAsuransi).HasMaxLength(8).IsUnicode(false);
            builder.Property(e => e.TelpAsuransi).HasMaxLength(20).IsUnicode(false);

            builder.Property(e => e.FaxAsuransi).HasMaxLength(20).IsUnicode(false);
            builder.Property(e => e.PihakBerwenang).HasMaxLength(50).IsUnicode(false);








        }
    }
}
