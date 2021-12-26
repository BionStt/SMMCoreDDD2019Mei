using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SumberMas2015.DDD.OutBox.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.InfrastructureData.Configuration
{
    public class OutBoxMessageConfiguration : IEntityTypeConfiguration<OutBoxMessage>
    {
        public void Configure(EntityTypeBuilder<OutBoxMessage> builder)
        {
            builder.ToTable("OutBoxMessages", "out");
            builder.HasKey(x => x.Id);
        }
    }
}
