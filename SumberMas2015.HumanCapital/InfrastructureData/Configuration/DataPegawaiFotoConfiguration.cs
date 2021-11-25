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
    public class DataPegawaiFotoConfiguration : IEntityTypeConfiguration<DataPegawaiFoto>
    {
        public void Configure(EntityTypeBuilder<DataPegawaiFoto> builder)
        {
            builder.ToTable("DataPegawaiFoto");
            builder.HasKey(x => x.DataPegawaiFotoId);
            builder.Property(x => x.NoUrutId).ValueGeneratedOnAdd();



        }
    }
}
