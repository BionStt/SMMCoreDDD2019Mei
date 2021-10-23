using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Persistence.Configurations
{
    public class DataPegawaiDataRiwayatPelatihanConfiguration : IEntityTypeConfiguration<DataPegawaiDataRiwayatPelatihan>
    {
        public void Configure(EntityTypeBuilder<DataPegawaiDataRiwayatPelatihan> builder)
        {
            builder.ToTable("DataPegawaiDataRiwayatPelatihan", "DataPegawai");

            // builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("DataPegawaiDataRiwayatPelatihan_hilo").IsRequired();
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

             builder.Property(e => e.AlamatLembaga)
                .HasColumnName("AlamatLembaga")
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.BidangPelatihan)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.DibiayaiOleh)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.DataPegawaiId);

            builder.Property(e => e.LamaKursus)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.NamaLembaga)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.TelpLembaga)
                .HasColumnName("TelpLembaga")
                .HasMaxLength(50)
                .IsUnicode(false);


        }
    }
}
