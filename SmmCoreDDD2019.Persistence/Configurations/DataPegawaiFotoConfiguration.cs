using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Persistence.Configurations
{
    public class DataPegawaiFotoConfiguration : IEntityTypeConfiguration<DataPegawaiFoto>
    {
        public void Configure(EntityTypeBuilder<DataPegawaiFoto> builder)
        {
            builder.ToTable("DataPegawaiFoto", "DataPegawai");
            builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("DataPegawaiFoto_hilo").IsRequired();
            builder.Property(e => e.Foto).HasColumnType("image");

            builder.Property(e => e.DataPegawaiId);

            builder.Property(e => e.KodeBarcode)
                .HasMaxLength(25)
                .IsUnicode(false);

            builder.Property(e => e.Revisi)
                .HasColumnName("revisi")
                .HasMaxLength(1)
                .IsUnicode(false);

            builder.Property(e => e.Tglinput).HasColumnType("datetime").HasDefaultValueSql("(getdate())");


         
        }
    }
}
