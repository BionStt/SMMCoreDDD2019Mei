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
    public class DataPerusahaanProsesBisnisConfiguration : IEntityTypeConfiguration<DataPerusahaanProsesBisnis>
    {
        public void Configure(EntityTypeBuilder<DataPerusahaanProsesBisnis> builder)
        {
            builder.ToTable("DataPerusahaanProsesBisnis");
            builder.HasKey(x => x.DataProsesBisnisId);
            builder.Property(x => x.NoUrutId).ValueGeneratedOnAdd();


        }
    }
}
