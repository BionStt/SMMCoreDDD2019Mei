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
    public class PurchaseOrderPembelianDetailConfiguration : IEntityTypeConfiguration<PembelianDetail>
    {
        public void Configure(EntityTypeBuilder<PembelianDetail> builder)
        {
            throw new NotImplementedException();
        }
    }
}
