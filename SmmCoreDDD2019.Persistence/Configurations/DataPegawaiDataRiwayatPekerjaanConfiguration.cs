using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmmCoreDDD2019.Domain.Entities;


namespace SmmCoreDDD2019.Persistence.Configurations
{
    public class DataPegawaiDataRiwayatPekerjaanConfiguration : IEntityTypeConfiguration<DataPegawaiDataRiwayatPekerjaan>
    {
        public void Configure(EntityTypeBuilder<DataPegawaiDataRiwayatPekerjaan> builder)
        {
            builder.HasKey(e => e.NoUrut);

            builder.ToTable("DataPegawaiDataRiwayatPekerjaan", "DataPegawai");

          builder.Property(e=>e.NoUrut).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;

            builder.Property(e => e.NamaPerusahaan)
               .HasMaxLength(50)
               .IsUnicode(false);

            builder.Property(e => e.AlamatP)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.KelurahanP)
         .HasColumnName("KelurahanP")
         .HasMaxLength(50)
         .IsUnicode(false);

            builder.Property(e => e.KecamatanP)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.KotaP)
               .HasColumnName("KotaP")
               .HasMaxLength(50)
               .IsUnicode(false);

            builder.Property(e => e.PropinsiP)
                .HasColumnName("PropinsiP")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.KodePosP)
              .HasMaxLength(7)
              .IsUnicode(false);

            builder.Property(e => e.AtasanP)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.GajiTerakhir).HasColumnType("money");

            builder.Property(e => e.IDPegawai).HasColumnName("IDPegawai");
            builder.Property(e => e.IDPegawai).ValueGeneratedNever();

          

            builder.Property(e => e.JabatanAwal)
                .HasMaxLength(50)
                .IsUnicode(false);
         
            builder.Property(e => e.Keterangan)
                .HasMaxLength(200)
                .IsUnicode(false);

          builder.Property(e => e.MulaiBekerja).HasColumnType("datetime");
            builder.Property(e => e.AkhirBekerja).HasColumnType("datetime");

            builder.Property(e => e.JabatanAkhir)
              .HasColumnName("JabatanAkhir")
              .HasMaxLength(50)
              .IsUnicode(false);

           

            builder.Property(e => e.TelpP)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.TglInput).HasColumnType("datetime").HasDefaultValueSql("(getdate())");

            builder.HasOne(d => d.DataPegawai)
              .WithMany(p => p.DataPegawaiDataRiwayatPekerjaan)
              .HasForeignKey(d => d.IDPegawai)
              .OnDelete(DeleteBehavior.ClientSetNull)
              .HasConstraintName("FK_DataPegawaiDataRiwayatPekerjaan_DataPegawai");

            //  throw new NotImplementedException();
        }
    }
}
