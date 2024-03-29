﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SumberMas2015.Inventory.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.InfrastructureData.Configuration
{
    public class StokUnitConfiguration : IEntityTypeConfiguration<StokUnit>
    {
        public void Configure(EntityTypeBuilder<StokUnit> builder)
        {
            builder.ToTable("StokUnit");
            builder.HasKey(e=>e.StokUnitId);

            builder.Property(e => e.NoUrutId).ValueGeneratedOnAdd();

            builder.Property(e=>e.Diskon).HasColumnType("money");
            builder.Property(e => e.Diskon2).HasColumnType("money");
            builder.Property(e => e.DiskonPPN).HasColumnType("money");
            builder.Property(e => e.Harga).HasColumnType("money");
            builder.Property(e => e.Harga1).HasColumnType("money");
            builder.Property(e => e.HargaPPN).HasColumnType("money");
            builder.Property(e => e.SellIn).HasColumnType("money");
            builder.Property(e => e.SellIn2).HasColumnType("money");
            builder.Property(e => e.SellInPPN).HasColumnType("money");
   

        }
    }
}
