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
    public class JenisPerjanjianKerjaConfiguration : IEntityTypeConfiguration<JenisPerjanjianKerja>
    {
        public void Configure(EntityTypeBuilder<JenisPerjanjianKerja> builder)
        {
            builder.ToTable("JenisPerjanjianKerja");
            builder.Property(x => x.NoUrutId).ValueGeneratedOnAdd();
            builder.HasKey(x => x.JenisPerjanjianKerjaId);



        }
    }
}
