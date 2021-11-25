using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SumberMas2015.Organization.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Organization.InfrastructureData.Configuration
{
    public class DataKamusKompetensiConfiguration : IEntityTypeConfiguration<DataKamusKompetensi>
    {
        public void Configure(EntityTypeBuilder<DataKamusKompetensi> builder)
        {
            builder.ToTable("DataKamusKompetensi");
            builder.HasKey(x => x.DataKamusKompetensiId);
            builder.Property(x => x.NoUrutId).ValueGeneratedOnAdd();



        }
    }
}
