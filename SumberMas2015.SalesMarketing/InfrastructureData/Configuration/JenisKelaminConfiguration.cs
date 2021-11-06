using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SumberMas2015.SalesMarketing.Domain.EnumInEntity;

namespace SumberMas2015.SalesMarketing.InfrastructureData.Configuration
{
    public class JenisKelaminConfiguration : IEntityTypeConfiguration<JenisKelamin>
    {
        public void Configure(EntityTypeBuilder<JenisKelamin> builder)
        {
            builder.ToTable("JenisKelamin");
            builder.HasKey(e => e.JenisKelaminId);
            builder.Property(e => e.NoUrutId).ValueGeneratedOnAdd();

            //builder.HasData(
            //    JenisKelamin.AddJenisKelamin("PRIA"),
            //    JenisKelamin.AddJenisKelamin("WANITA")
            //    );
        }
    }
}
