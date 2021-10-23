using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmmCoreDDD2019.Domain.Entities;


namespace SmmCoreDDD2019.Persistence.Configurations
{
    public class DataPegawaiDataOrmasConfiguration : IEntityTypeConfiguration<DataPegawaiDataOrmas>
    {
        public void Configure(EntityTypeBuilder<DataPegawaiDataOrmas> builder)
        {
            builder.ToTable("DataPegawaiDataOrmas", "DataPegawai");


            //   builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("DataPegawaiDataOrmas_hilo").IsRequired();
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.AlamatOrmas)
                .HasColumnName("AlamatOrmas")
                .HasMaxLength(300)
                .IsUnicode(false);

            builder.Property(e => e.DataPegawaiId);

          builder.Property(e => e.Jabatan)
                .HasColumnName("Jabatan")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.JenisKegiatan)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.KotaOrmas)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.NamaOrmas)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.TelpOrmas)
                .HasColumnName("TelpOrmas")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.TglInput)
              .HasColumnType("datetime")
              .HasDefaultValueSql("(getdate())");


        }
    }
}
