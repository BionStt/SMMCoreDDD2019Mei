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
    public class DataPegawaiDataBankConfiguration : IEntityTypeConfiguration<DataPegawaiDataBank>
    {
        public void Configure(EntityTypeBuilder<DataPegawaiDataBank> builder)
        {
            builder.ToTable("DataPegawaiDataBank");
            builder.HasKey(x => x.DataPegawaiDataBankId);
            builder.Property(x => x.NoUrutId).ValueGeneratedOnAdd();

            
        }
    }
}
