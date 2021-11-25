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
    public class LeavesHRDConfiguration : IEntityTypeConfiguration<LeavesHRD>
    {
        public void Configure(EntityTypeBuilder<LeavesHRD> builder)
        {
            builder.ToTable("LeavesHRD");
            builder.HasKey(x => x.LeavesHRDId);
            builder.Property(x => x.NoUrutId).ValueGeneratedOnAdd();




        }
    }
}
