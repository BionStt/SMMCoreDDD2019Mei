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
    public class DataPegawaiDataLeavesConfiguration : IEntityTypeConfiguration<DataPegawaiDataLeaves>
    {
        public void Configure(EntityTypeBuilder<DataPegawaiDataLeaves> builder)
        {
            builder.ToTable("DataPegawaiDataLeaves");
            builder.HasKey(x => x.DataPegawaiDataLeavesId);
            builder.Property(x => x.DataPegawaiDataLeavesId).ValueGeneratedOnAdd();



        }
    }
}
