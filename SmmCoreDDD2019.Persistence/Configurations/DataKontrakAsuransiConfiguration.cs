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

            builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("DataKontrakAsuransi_hilo").IsRequired();
            builder.Property(e => e.NoRegistrasiKontrakAsuransi).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.DataKontrakKreditId);
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
