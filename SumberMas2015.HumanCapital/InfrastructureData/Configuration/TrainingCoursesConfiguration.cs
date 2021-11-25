using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SumberMas2015.HumanCapital.Domain.EnumInEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.HumanCapital.InfrastructureData.Configuration
{
    public class TrainingCoursesConfiguration : IEntityTypeConfiguration<TrainingCourses>
    {
        public void Configure(EntityTypeBuilder<TrainingCourses> builder)
        {
            builder.ToTable("TrainingCourses");
            builder.HasKey(x => x.TrainingCoursesId);
            builder.Property(x => x.NoUrutId).ValueGeneratedOnAdd();



        }
    }
}
