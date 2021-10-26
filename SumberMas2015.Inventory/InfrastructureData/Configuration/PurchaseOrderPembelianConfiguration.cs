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
    public class PurchaseOrderPembelianConfiguration : IEntityTypeConfiguration<PurchaseOrderPembelian>
    {
        public void Configure(EntityTypeBuilder<PurchaseOrderPembelian> builder)
        {
            throw new NotImplementedException();
        }
    }
}
