using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SumberMas2015.Organization.Domain.EnumInEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Organization.InfrastructureData.Configuration
{
    public class JenisKompetensiConfiguration : IEntityTypeConfiguration<JenisKompetensi>
    {
        public void Configure(EntityTypeBuilder<JenisKompetensi> builder)
        {
            builder.ToTable("JenisKompetensi");
            builder.HasKey(x => x.JenisKompetensiId);
            builder.Property(x => x.NoUrutId).ValueGeneratedOnAdd();



        }
    }
}
