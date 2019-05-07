using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Persistence.Configurations
{
    public class DataPegawaiDataKeluargaConfiguration : IEntityTypeConfiguration<DataPegawaiDataKeluarga>
    {
        public void Configure(EntityTypeBuilder<DataPegawaiDataKeluarga> builder)
        {
            builder.HasKey(e => e.NoUrut);

            builder.Property(e=>e.NoUrut).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;

           
            builder.ToTable("DataPegawaiDataKeluarga", "DataPegawai");

            builder.Property(e => e.Agama)
                .HasMaxLength(1)
                .IsUnicode(false);

            builder.Property(e => e.AlamatK)
                .HasColumnName("alamatK")
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.EmergencyCall)
                .HasMaxLength(1)
                .IsUnicode(false);

            builder.Property(e => e.HubunganK)
                .HasMaxLength(1)
                .IsUnicode(false);

            builder.Property(e => e.IDPegawai).HasColumnName("IDPegawai");

            builder.Property(e => e.IDPegawai).ValueGeneratedNever();

            builder.Property(e => e.JenisKelamin)
                .HasMaxLength(1)
                .IsUnicode(false);

            builder.Property(e => e.KecamatanK)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.KelurahanK)
                .HasColumnName("kelurahanK")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Keterangan)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.KodePosK)
                .HasMaxLength(10)
                .IsUnicode(false);

            builder.Property(e => e.KotaK)
                .HasMaxLength(50)
                .IsUnicode(false);
            builder.Property(e => e.PropinsiK)
               .HasMaxLength(50)
               .IsUnicode(false);

            builder.Property(e => e.Telp)
      .HasMaxLength(20)
      .IsUnicode(false);

            builder.Property(e => e.Handphone)
                .HasMaxLength(20)
                .IsUnicode(false);


            builder.Property(e => e.NamaK)
                .HasMaxLength(40)
                .IsUnicode(false);

            builder.Property(e => e.NoKtp)
                .HasColumnName("NoKTP")
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.Pekerjaan)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.PendidikanTerakhir)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.TempatLahir)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Tgllahir)
                .HasColumnName("Tgllahir")
                .HasColumnType("datetime");

            builder.Property(e => e.TglInput)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.HasOne(d => d.DataPegawai)
                 .WithMany(p => p.DataPegawaiDataKeluarga)
                 .HasForeignKey(d => d.IDPegawai)
                 .OnDelete(DeleteBehavior.ClientSetNull)
                 .HasConstraintName("FK_DataPegawaiDataKeluarga_DataPegawai");



            //  throw new NotImplementedException();
        }
    }
}
