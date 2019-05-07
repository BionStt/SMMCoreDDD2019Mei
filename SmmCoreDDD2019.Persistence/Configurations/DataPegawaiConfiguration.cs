using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmmCoreDDD2019.Domain.Entities;


namespace SmmCoreDDD2019.Persistence.Configurations
{
    public class DataPegawaiConfiguration : IEntityTypeConfiguration<DataPegawai>
    {
        public void Configure(EntityTypeBuilder<DataPegawai> builder)
        {
            builder.HasKey(e => e.IDPegawai);

            builder.ToTable("DataPegawai", "DataPegawai");

            builder.Property(e => e.IDPegawai).HasColumnName("IDPegawai");

            builder.Property(e=>e.NoRegistrasiPegawai).HasColumnName("NoRegistrasiPegawai").HasMaxLength(50);

            builder.Property(e => e.IDPegawai).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;

            builder.Property(e => e.Aktif)
                .HasMaxLength(1)
                .IsUnicode(false);

            builder.Property(e => e.TglBerhentiKerja).HasColumnType("datetime");

            builder.Property(e => e.TglInput).HasColumnType("datetime").HasDefaultValueSql("(getdate())");

            builder.Property(e => e.TglMulaiKerja).HasColumnType("datetime");

            builder.Property(e=>e.ApplicationUserId).HasColumnName("ApplicationUserId") ;
         

        }
    }
}
