using System;
using System.Collections.Generic;
using System.Text;


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Persistence.Configurations
{
    public class DataPegawaiDataRiwayatPendidikanConfiguration : IEntityTypeConfiguration<DataPegawaiDataRiwayatPendidikan>
    {
        public void Configure(EntityTypeBuilder<DataPegawaiDataRiwayatPendidikan> builder)
        {
            builder.HasKey(e => e.NoUrut);

             builder.ToTable("DataPegawaiDataRiwayatPendidikan", "DataPegawai");

            builder.Property(e=>e.NoUrut).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;

            builder.Property(e => e.IDPegawai).HasColumnName("IDPegawai");
            builder.Property(e => e.IDPegawai).ValueGeneratedNever();

            builder.Property(e => e.Jurusan)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Keterangan)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Kota)
                .HasColumnName("Kota")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.NamaSekolah)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.TingkatPend).HasColumnType("nchar(10)");

            builder.HasOne(d => d.DataPegawai)
         .WithMany(p => p.DataPegawaiDataRiwayatPendidikan)
         .HasForeignKey(d => d.IDPegawai)
         .OnDelete(DeleteBehavior.ClientSetNull)
         .HasConstraintName("FK_DataPegawaiDataRiwayatPendidikan_DataPegawai");

            //  throw new NotImplementedException();
        }
    }
}
