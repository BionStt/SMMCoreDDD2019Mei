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
    public class DataPegawaiDataPengalamanTrainingConfiguration : IEntityTypeConfiguration<DataPegawaiDataPengalamanTraining>
    {
        public void Configure(EntityTypeBuilder<DataPegawaiDataPengalamanTraining> builder)
        {
            builder.ToTable("DataPegawaiDataPengalamanTraining");
            builder.HasKey(x => x.DataPegawaiDataPengalamanTrainingId);
            builder.Property(x => x.NoUrutId).ValueGeneratedOnAdd();



        }
    }
}
