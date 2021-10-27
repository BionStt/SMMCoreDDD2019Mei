using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SumberMas2015.HumanCapital.Domain.EnumInEntity;

namespace SumberMas2015.HumanCapital.InfrastructureData.Configuration
{
    public class AgamaConfiguration : IEntityTypeConfiguration<Agama>
    {
        public void Configure(EntityTypeBuilder<Agama> builder)
        {
            builder.ToTable("Agama");
            builder.HasKey(e => e.NoUrutId);
            builder.Property(e => e.NoUrutId).ValueGeneratedOnAdd(); throw new NotImplementedException();



        }
    }
}
