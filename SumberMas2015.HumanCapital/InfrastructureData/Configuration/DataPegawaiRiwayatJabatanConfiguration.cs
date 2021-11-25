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
    public class DataPegawaiRiwayatJabatanConfiguration : IEntityTypeConfiguration<DataPegawaiRiwayatJabatan>
    {
        public void Configure(EntityTypeBuilder<DataPegawaiRiwayatJabatan> builder)
        {
            builder.ToTable("DataPegawaiRiwayatJabatan");
            builder.HasKey(x => x.DataPegawaiRiwayatJabatanId);
            builder.Property(x => x.NoUrutId).ValueGeneratedOnAdd();



        }
    }
}
