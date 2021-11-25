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
    public class DataPerusahaanJobDescriptionConfiguration : IEntityTypeConfiguration<DataPerusahaanJobDescription>
    {
        public void Configure(EntityTypeBuilder<DataPerusahaanJobDescription> builder)
        {
            builder.ToTable("DataPerusahaanJobDescription");
            builder.HasKey(x => x.DataPerusahaanJobDescriptionId);
            builder.Property(x => x.NoUrutId).ValueGeneratedOnAdd();


        }
    }
}
