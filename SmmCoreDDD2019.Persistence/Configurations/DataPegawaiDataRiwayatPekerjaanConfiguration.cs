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
            builder.ToTable("DataPegawaiDataRiwayatPekerjaan", "DataPegawai");

            builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("DataPegawaiDataRiwayatPekerjaan_hilo").IsRequired();
         
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

            builder.Property(e => e.DataPegawaiId);

          

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

         
        }
    }
}
