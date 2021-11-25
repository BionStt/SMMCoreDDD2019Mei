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
    public class JenisAbsensiConfiguration : IEntityTypeConfiguration<JenisAbsensi>
    {
        public void Configure(EntityTypeBuilder<JenisAbsensi> builder)
        {
              builder.ToTable("JenisAbsensi");
            builder.HasKey(x => x.JenisAbsensiId);
            builder.Property(x => x.NoUrutId).ValueGeneratedOnAdd();

        }
    }
}
