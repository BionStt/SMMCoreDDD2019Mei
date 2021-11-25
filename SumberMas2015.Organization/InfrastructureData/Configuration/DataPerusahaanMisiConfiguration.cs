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
    public class DataPerusahaanMisiConfiguration : IEntityTypeConfiguration<DataPerusahaanMisi>
    {
        public void Configure(EntityTypeBuilder<DataPerusahaanMisi> builder)
        {
            builder.ToTable("DataPerusahaanMisi");
            builder.HasKey(x => x.DataPerusahaanMisiId);
            builder.Property(x => x.NoUrutId).ValueGeneratedOnAdd();

        }
    }
}
