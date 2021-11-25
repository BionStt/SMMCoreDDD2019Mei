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
    public class DataPegawaiRiwayatPendidikanConfiguration : IEntityTypeConfiguration<DataPegawaiRiwayatPendidikan>
    {
        public void Configure(EntityTypeBuilder<DataPegawaiRiwayatPendidikan> builder)
        {
            builder.ToTable("DataPegawaiRiwayatPendidikan");
            builder.HasKey(x => x.DataPegawaiId);
            builder.Property(x => x.NoUrutId).ValueGeneratedOnAdd();


        }
    }
}
