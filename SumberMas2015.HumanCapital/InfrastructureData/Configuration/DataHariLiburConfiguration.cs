using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SumberMas2015.HumanCapital.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.HumanCapital.InfrastructureData.Configuration
{
    public class DataHariLiburConfiguration : IEntityTypeConfiguration<DataHariLibur >
    {
        public void Configure(EntityTypeBuilder<DataHariLibur> builder)
        {
            builder.ToTable("DataHariLibur");
            builder.HasKey(x => x.DataHariLiburId);
            builder.Property(x => x.NoUrutId).ValueGeneratedOnAdd();


        }
    }
}
