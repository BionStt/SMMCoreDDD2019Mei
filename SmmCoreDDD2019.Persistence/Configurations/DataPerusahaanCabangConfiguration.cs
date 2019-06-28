using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Persistence.Configurations
{
    public class DataPerusahaanCabangConfiguration : IEntityTypeConfiguration<DataPerusahaanCabang>
    {
        public void Configure(EntityTypeBuilder<DataPerusahaanCabang> builder)
        {
            builder.ToTable("DataPerusahaanCabang", "DataPerusahaan");
            builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("DataPerusahaanCabang_hilo").IsRequired();

            builder.Property(e=>e.DataPerusahaanId);

            builder.Property(e => e.Alamat)
                .HasColumnName("Alamat")
                .HasMaxLength(50);

            builder.Property(e => e.Cp)
                .HasColumnName("CP")
                .HasMaxLength(50)
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

            builder.Property(e => e.NamaPosisi)
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(e => e.Telp)
                .HasColumnName("Telp")
                .HasMaxLength(20);

        }
    }
}
