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
    public class PurchaseOrderPembelianDetailConfiguration : IEntityTypeConfiguration<PurchaseOrderPembelianDetail>
    {
        public void Configure(EntityTypeBuilder<PurchaseOrderPembelianDetail> builder)
        {
            builder.ToTable("PurchaseOrderPembelianDetail");
            builder.Property(e => e.Bbn).HasColumnType("money");
            builder.Property(e => e.Diskon).HasColumnType("money");
            builder.Property(e => e.OffTheRoad).HasColumnType("money");
   
  


        }
    }
}
