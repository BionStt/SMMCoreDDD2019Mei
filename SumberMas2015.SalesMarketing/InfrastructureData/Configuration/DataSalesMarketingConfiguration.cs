using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SumberMas2015.SalesMarketing.Domain;

namespace SumberMas2015.SalesMarketing.InfrastructureData.Configuration
{
    public class DataSalesMarketingConfiguration : IEntityTypeConfiguration<DataSalesMarketing>
    {
        public void Configure(EntityTypeBuilder<DataSalesMarketing> builder)
        {
            builder.ToTable("DataSalesMarketing");
            builder.Property(e => e.NoUrutId).ValueGeneratedOnAdd();


        }
    }
}
