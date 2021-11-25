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
    public class DataPegawaiDataKeluargaConfiguration : IEntityTypeConfiguration<DataPegawaiDataKeluarga>
    {
        public void Configure(EntityTypeBuilder<DataPegawaiDataKeluarga> builder)
        {
            builder.ToTable("DataPegawaiDataKeluarga");
            builder.HasKey(x => x.DataPegawaiDataKeluargaId);
            builder.Property(x => x.NoUrutId).ValueGeneratedOnAdd();



        }
    }
}
