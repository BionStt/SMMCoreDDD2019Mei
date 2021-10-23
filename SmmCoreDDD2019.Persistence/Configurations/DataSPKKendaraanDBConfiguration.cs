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
            builder.ToTable("DataSPKKendaraanDB", "DataSPKBaruDB");
            //  builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("DataSPKKendaraanDB_hilo").IsRequired();
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.NamaSTNK)
                .HasColumnName("NamaSTNK")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.NoKtpSTNK)
                        .HasColumnName("NoKtpSTNK")
                        .HasMaxLength(100)
                        .IsUnicode(false);

            builder.Property(e => e.DataSPKBaruDBId);

            builder.Property(e => e.MasterBarangDBId);

            builder.Property(e => e.TahunPerakitan)
                        .HasColumnName("tahunPerakitan")
                        .HasMaxLength(5)
                        .IsUnicode(false);

            builder.Property(e => e.Warna)
                        .HasMaxLength(35)
                        .IsUnicode(false);


        }
    }
}
