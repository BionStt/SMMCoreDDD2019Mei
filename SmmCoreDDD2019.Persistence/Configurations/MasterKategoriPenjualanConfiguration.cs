using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmmCoreDDD2019.Domain.Entities;


namespace SmmCoreDDD2019.Persistence.Configurations
{
    public class MasterKategoriPenjualanConfiguration : IEntityTypeConfiguration<MasterKategoriPenjualan>
    {
        public void Configure(EntityTypeBuilder<MasterKategoriPenjualan> builder)
        {
            builder.HasKey(e => e.NoUrutKategoriPenjualan);

            builder.ToTable("MasterKategoriPenjualan");

            builder.Property(e=>e.NoUrutKategoriPenjualan).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;

            builder.Property(e => e.NamaKategoryPenjualan)
                .HasMaxLength(50)
                .IsUnicode(false);

            // throw new NotImplementedException();
        }
    }
}
