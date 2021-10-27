using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SumberMas2015.Organization.Domain;

namespace SumberMas2015.Organization.InfrastructureData.Configuration
{
    public class DataPerusahaanConfiguration : IEntityTypeConfiguration<DataPerusahaan>
    {
        public void Configure(EntityTypeBuilder<DataPerusahaan> builder)
        {
            builder.ToTable("DataPerusahaan");
            builder.HasKey(e => e.NoUrutId);
            builder.Property(e => e.NoUrutId).ValueGeneratedOnAdd();
        }
    }
}
