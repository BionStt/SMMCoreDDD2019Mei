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
    public class DataPerusahaanVisiConfiguration : IEntityTypeConfiguration<DataPerusahaanVisi>
    {
        public void Configure(EntityTypeBuilder<DataPerusahaanVisi> builder)
        {
            builder.ToTable("DataPerusahaanVisi");
            builder.HasKey(x => x.DataPerusahaanVisiId);
            builder.Property(x => x.NoUrutId).ValueGeneratedOnAdd();




        }
    }
}
