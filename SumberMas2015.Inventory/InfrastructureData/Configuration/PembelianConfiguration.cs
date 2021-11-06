using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SumberMas2015.Inventory.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.InfrastructureData.Configuration
{
    public class PembelianConfiguration : IEntityTypeConfiguration<Pembelian>
    {
        public void Configure(EntityTypeBuilder<Pembelian> builder)
        {
            builder.ToTable("Pembelian");
            builder.HasKey(e => e.PembelianId);
            builder.Property(e => e.NoUrutId).ValueGeneratedOnAdd();

            builder.Property(e => e.TanggalBeli).HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");


        }
    }
}
