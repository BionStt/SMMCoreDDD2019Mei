using System;
using System.Collections.Generic;
using System.Text;


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Persistence.Configurations
{
    public class MasterBarangDBConfiguration : IEntityTypeConfiguration<MasterBarangDB>
    {
        public void Configure(EntityTypeBuilder<MasterBarangDB> builder)
        {
            
            builder.HasKey(e => e.NoUrutTypeKendaraan);

            builder.ToTable("MasterBarangDB");

            builder.Property(e=>e.NoUrutTypeKendaraan).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;

            builder.Property(e => e.NoUrutTypeKendaraan).HasColumnName("NoUrutTypeKendaraan");

            builder.Property(e => e.Aktif)
                .HasMaxLength(1)
                .IsUnicode(false);

            builder.Property(e => e.BBN)
                .HasColumnName("BBN")
                .HasColumnType("money");

            builder.Property(e => e.Cc)
                .HasColumnName("CC")
                .HasMaxLength(10)
                .IsUnicode(false);

            builder.Property(e => e.Harga).HasColumnType("money");

            builder.Property(e => e.Merek)
                .HasMaxLength(150)
                .IsUnicode(false);

            builder.Property(e => e.NamaBarang)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.NomorRangka)
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.NomorMesin)
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.Tipe)
                .HasMaxLength(15)
                .IsUnicode(false);

            builder.Property(e => e.TypeKendaraan)
                .IsRequired()
                .HasColumnName("TypeKendaraan")
                .HasMaxLength(30)
                .IsUnicode(false);



            // throw new NotImplementedException();
        }
    }
}
