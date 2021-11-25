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
    public class DataPegawaiDataOrmasConfiguration : IEntityTypeConfiguration<DataPegawaiDataOrmas>
    {
        public void Configure(EntityTypeBuilder<DataPegawaiDataOrmas> builder)
        {
            builder.ToTable("DataPegawaiDataOrmas");
            builder.HasKey(x => x.DataPegawaiDataOrmasId);
            builder.Property(x => x.NoUrutId).ValueGeneratedNever();


        }
    }
}
