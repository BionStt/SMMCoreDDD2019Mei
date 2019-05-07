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
    public class PembelianDetailConfiguration : IEntityTypeConfiguration<PembelianDetail>
    {
        public void Configure(EntityTypeBuilder<PembelianDetail> builder)
        {
            builder.HasKey(e => e.KodeBeliDetail);

            builder.ToTable("PembelianDetail","Pembelian");

            builder.Property(e => e.KodeBeliDetail).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;

            builder.Property(e => e.KodeBeliDetail).HasColumnName("KodeBeliDetail");

            builder.Property(e => e.KodeBeli).HasColumnName("KodeBeli");

            builder.Property(e => e.KodeBrg).HasColumnName("KodeBrg");

            builder.Property(e => e.HargaOffTheRoad).HasColumnType("money");

            builder.Property(e => e.BBN)
             .HasColumnName("BBN")
             .HasColumnType("money");

            builder.Property(e => e.Qty).HasColumnName("Qty");

            builder.Property(e => e.Diskon)
            .HasColumnName("Diskon")
            .HasColumnType("money");

            builder.Property(e => e.SellIn)
        .HasColumnName("SellIn")
        .HasColumnType("money");

            builder.Property(e => e.Harga1)
        .HasColumnName("Harga1")
        .HasColumnType("money");

            builder.Property(e => e.Diskon2)
        .HasColumnName("Diskon2")
        .HasColumnType("money");

            builder.Property(e => e.SellIn2)
        .HasColumnName("SellIn2")
        .HasColumnType("money");

            builder.Property(e => e.HargaPPN)
        .HasColumnName("HargaPPN")
        .HasColumnType("money");

            builder.Property(e => e.DiskonPPN)
        .HasColumnName("DiskonPPN")
        .HasColumnType("money");

            builder.Property(e => e.SellInPPN)
      .HasColumnName("SellInPPN")
      .HasColumnType("money");



        }
    }
}
