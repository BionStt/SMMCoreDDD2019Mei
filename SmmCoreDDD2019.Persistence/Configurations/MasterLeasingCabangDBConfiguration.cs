using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmmCoreDDD2019.Domain.Entities;


namespace SmmCoreDDD2019.Persistence.Configurations
{
    public class MasterLeasingCabangDBConfiguration : IEntityTypeConfiguration<MasterLeasingCabangDB>
    {
        public void Configure(EntityTypeBuilder<MasterLeasingCabangDB> builder)
        {
            builder.ToTable("MasterLeasingCabangDB", "MasterLeasingDb");
           // builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("MasterLeasingCabangDB_hilo").IsRequired();
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

         builder.Property(e => e.MasterLeasingDbId);

            builder.Property(e => e.Aktif)
                .HasMaxLength(2)
                .IsUnicode(false);

            builder.Property(e => e.Alamat)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Kelurahan)
               .HasMaxLength(50)
               .IsUnicode(false);

            builder.Property(e => e.Kecamatan)
               .HasMaxLength(50)
               .IsUnicode(false);

            builder.Property(e => e.Kota)
               .HasMaxLength(50)
               .IsUnicode(false);

            builder.Property(e => e.Propinsi)
               .HasMaxLength(50)
               .IsUnicode(false);

            builder.Property(e => e.KodePos)
               .HasMaxLength(10)
               .IsUnicode(false);

            builder.Property(e => e.Cabang)
                .HasColumnName("Cabang")
                .HasMaxLength(30)
                .IsUnicode(false);

           builder.Property(e => e.Telp)
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.Faks)
               .HasMaxLength(20)
               .IsUnicode(false);

            builder.Property(e => e.Email)
              .HasMaxLength(30)
              .IsUnicode(false);


        }
    }
}
