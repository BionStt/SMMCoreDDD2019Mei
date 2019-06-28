using System;
using System.Collections.Generic;
using System.Text;


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Persistence.Configurations
{
    public class DataPerusahaanConfiguration : IEntityTypeConfiguration<DataPerusahaan>
    {
        public void Configure(EntityTypeBuilder<DataPerusahaan> builder)
        {
            builder.ToTable("DataPerusahaan", "DataPerusahaan");
            builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("DataPerusahaan_hilo").IsRequired();

          builder.Property(e=>e.NoRegDataPerusahaan).HasColumnName("NoRegDataPerusahaan").HasMaxLength(50);

          
            builder.Property(e => e.AlamatP).HasMaxLength(50);

            builder.Property(e => e.Cs)
                .HasColumnName("CS")
                .HasMaxLength(40)
                .IsUnicode(false);

            builder.Property(e => e.Kec)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Kel)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.KodePos)
                .HasMaxLength(7)
                .IsUnicode(false);

            builder.Property(e => e.Kota).HasMaxLength(50);
            builder.Property(e => e.Propinsi).HasMaxLength(50);

            builder.Property(e => e.NamaP)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Telp).HasMaxLength(25);

          
        }
    }
}
