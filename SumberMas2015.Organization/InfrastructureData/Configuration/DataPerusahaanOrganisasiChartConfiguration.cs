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
    public class DataPerusahaanOrganisasiChartConfiguration : IEntityTypeConfiguration<DataPerusahaanOrganisasiChart>
    {
        public void Configure(EntityTypeBuilder<DataPerusahaanOrganisasiChart> builder)
        {
            builder.ToTable("DataPerusahaanOrganisasiChart");
            builder.HasKey(x => x.DataPerusahaanOrganisasiChartId);
            builder.Property(x => x.NoUrutId).ValueGeneratedOnAdd();



        }
    }
}
