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
    public class DataKamusKompetensiIndikatorPerilakuConfiguration : IEntityTypeConfiguration<DataKamusKompetensiIndikatorPerilaku>
    {
        public void Configure(EntityTypeBuilder<DataKamusKompetensiIndikatorPerilaku> builder)
        {
            builder.ToTable("DataKamusKompetensiIndikatorPerilaku");
            builder.Property(x => x.NoUrutId).ValueGeneratedOnAdd();
            builder.HasKey(x => x.DataKamusKompetensiIndikatorPerilakuId);



        }
    }
}
