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
    public class DataPegawaiDataPribadiConfiguration : IEntityTypeConfiguration<DataPegawaiDataPribadi>
    {
        public void Configure(EntityTypeBuilder<DataPegawaiDataPribadi> builder)
        {
            builder.ToTable("DataPegawaiDataPribadi");
            builder.HasKey(x => x.DataPegawaiDataPribadiId);
            builder.Property(x => x.NoUrutId).ValueGeneratedOnAdd();


        }
    }
}
