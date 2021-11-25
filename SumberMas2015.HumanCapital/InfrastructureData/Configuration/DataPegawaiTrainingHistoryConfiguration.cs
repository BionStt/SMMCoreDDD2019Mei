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
    public class DataPegawaiTrainingHistoryConfiguration : IEntityTypeConfiguration<DataPegawaiTrainingHistory>
    {
        public void Configure(EntityTypeBuilder<DataPegawaiTrainingHistory> builder)
        {
            builder.ToTable("DataPegawaiTrainingHistory");
            builder.HasKey(x => x.TrainingCoursesId);
            builder.Property(x => x.NoUrutId).ValueGeneratedOnAdd();



        }
    }
}
