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

           // builder.HasKey(e => new { e.KodeP, e.KodePosisi });
            builder.HasKey(e => e.KodePosisi);
            builder.ToTable("DataPerusahaanCabang", "DataPerusahaan");
         

            builder.Property(e=>e.KodePosisi).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;

            //   builder.Property(e => e.KodePosisi).ValueGeneratedOnAdd();
            builder.Property(e=>e.KodeP).ValueGeneratedNever();

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

            builder.HasOne(d => d.DataPerusahaan)
                .WithMany(p => p.DataPerusahaanCabang)
                .HasForeignKey(d => d.KodeP)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DataPerusahaanCabang_DataPerusahaan");




            //    throw new NotImplementedException();
        }
    }
}
