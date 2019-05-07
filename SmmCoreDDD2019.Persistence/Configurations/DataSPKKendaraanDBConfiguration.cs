using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmmCoreDDD2019.Domain.Entities;


namespace SmmCoreDDD2019.Persistence.Configurations
{
   public class DataSPKKendaraanDBConfiguration : IEntityTypeConfiguration<DataSPKKendaraanDB>
    {
       
        public void Configure(EntityTypeBuilder<DataSPKKendaraanDB> builder)
        {

            builder.HasKey(e => e.NoUrut);
            builder.ToTable("DataSPKKendaraanDB", "DataSPKBaruDB");

          

            builder.Property(e=>e.NoUrut).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;

            builder.Property(e => e.NamaSTNK)
                .HasColumnName("NamaSTNK")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.NoKtpSTNK)
                        .HasColumnName("NoKtpSTNK")
                        .HasMaxLength(100)
                        .IsUnicode(false);

            builder.Property(e => e.NoUrutSPKBaru).HasColumnName("NoUrutSPKBaru");
            builder.Property(e => e.NoUrutSPKBaru).ValueGeneratedNever();

            builder.Property(e => e.NoUrutTypeKendaraan).HasColumnName("NoUrutTypeKendaraan");

            builder.Property(e => e.TahunPerakitan)
                        .HasColumnName("tahunPerakitan")
                        .HasMaxLength(5)
                        .IsUnicode(false);

            builder.Property(e => e.Warna)
                        .HasMaxLength(35)
                        .IsUnicode(false);

            builder.HasOne(d=>d.DataSPKBaruDB)
                .WithMany(p=>p.DataSPKKendaraanDB)
                .HasForeignKey(d=>d.NoUrutSPKBaru)
                  .OnDelete(DeleteBehavior.ClientSetNull)
         .HasConstraintName("FK_DataSPKKendaraanDB_DataSPKBaruDB");

            // throw new NotImplementedException();
        }
    }
}
