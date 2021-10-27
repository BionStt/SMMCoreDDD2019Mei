using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SumberMas2015.HumanCapital.Domain;

namespace SumberMas2015.HumanCapital.InfrastructureData.Configuration
{
    public class DataPegawaiConfiguration : IEntityTypeConfiguration<DataPegawai>
    {
        public void Configure(EntityTypeBuilder<DataPegawai> builder)
        {
            builder.ToTable("DataPegawai");
            builder.HasKey(e => e.NoUrutId);
            builder.Property(e => e.NoUrutId).ValueGeneratedOnAdd();
        }
    }
}
