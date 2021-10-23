using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Persistence.Configurations
{
    public class DataSPKBaruDBConfiguration : IEntityTypeConfiguration<DataSPKBaruDB>
    {
        public void Configure(EntityTypeBuilder<DataSPKBaruDB> builder)
        {
            builder.ToTable("DataSPKBaruDB", "DataSPKBaruDB");
            // builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("DataSPKBaruDB_hilo").IsRequired();
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e=>e.NoRegistrasiSPK).HasColumnName("NoRegistrasiSPK").HasMaxLength(50);

             builder.Property(e => e.LokasiSpk)
                .HasColumnName("LokasiSpk")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Terinput)
                .HasMaxLength(1)
                .IsUnicode(false);

            builder.Property(e => e.TglInput).HasColumnType("datetime").HasDefaultValueSql("(getdate())");

            builder.Property(e => e.Tolak)
                .HasMaxLength(1)
                .IsUnicode(false);

            builder.Property(e => e.UserInput)
                .HasMaxLength(30)
                .IsUnicode(false);
        }
    }
}
