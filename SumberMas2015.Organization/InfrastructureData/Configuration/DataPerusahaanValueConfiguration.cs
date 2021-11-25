using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SumberMas2015.Organization.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Organization.InfrastructureData.Configuration
{
    public class DataPerusahaanValueConfiguration : IEntityTypeConfiguration<DataPerusahaanValue>
    {
        public void Configure(EntityTypeBuilder<DataPerusahaanValue> builder)
        {
            builder.ToTable("DataPerusahaanValue");
            builder.HasKey(x => x.DataPerusahaanValueId);
            builder.Property(x => x.NoUrutId).ValueGeneratedOnAdd();


        }
    }
}
