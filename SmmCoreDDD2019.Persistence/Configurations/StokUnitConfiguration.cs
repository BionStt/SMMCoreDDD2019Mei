using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Persistence.Configurations
{
    public class StokUnitConfiguration : IEntityTypeConfiguration<StokUnit>
    {
        public void Configure(EntityTypeBuilder<StokUnit> builder)
        {
            builder.HasKey(e => e.NoUrutSo);
            builder.ToTable("StokUnit", "Pembelian");
            builder.Property(e => e.NoUrutSo).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;

            builder.Property(e => e.KodeBeliDetail).HasColumnName("KodeBeliDetail");

            builder.Property(e => e.KodeBrg).HasColumnName("KodeBrg");

            builder.Property(e => e.NoRangka).HasColumnName("NoRangka")
                .HasMaxLength(30)
              .IsUnicode(false);

            builder.Property(e => e.NoMesin).HasColumnName("NoMesin")
                 .HasMaxLength(30)
              .IsUnicode(false);

            builder.Property(e => e.Warna).HasColumnName("Warna")
              .HasMaxLength(40)
              .IsUnicode(false);

            builder.Property(e => e.Jual).HasColumnName("Jual")
                 .HasMaxLength(1)
              .IsUnicode(false); 

            builder.Property(e => e.Kembali).HasColumnName("Kembali")
                 .HasMaxLength(1)
              .IsUnicode(false); 

            builder.Property(e => e.Faktur).HasColumnName("Faktur")
                 .HasMaxLength(1)
              .IsUnicode(false); 

            builder.Property(e => e.Harga).HasColumnName("Harga").HasColumnType("money");

            builder.Property(e => e.Diskon).HasColumnName("Diskon").HasColumnType("money");

            builder.Property(e => e.SellIn).HasColumnName("SellIn").HasColumnType("money");

            builder.Property(e => e.Harga1).HasColumnName("Harga1").HasColumnType("money");

            builder.Property(e => e.Diskon2).HasColumnName("Diskon2").HasColumnType("money");

            builder.Property(e => e.SellIn2).HasColumnName("SellIn2").HasColumnType("money");

            builder.Property(e => e.HargaPPN).HasColumnName("HargaPPN").HasColumnType("money");

            builder.Property(e => e.DiskonPPN).HasColumnName("DiskonPPN").HasColumnType("money");

            builder.Property(e => e.SellInPPN).HasColumnName("SellInPPN").HasColumnType("money");

            builder.Property(e => e.TglInput).HasColumnName("TglInput").HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");








        }
    }
}
