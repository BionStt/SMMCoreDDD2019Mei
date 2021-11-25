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
    public class DataPegawaiDataKinerjaConfiguration : IEntityTypeConfiguration<DataPegawaiDataKinerja>
    {
        public void Configure(EntityTypeBuilder<DataPegawaiDataKinerja> builder)
        {
            builder.ToTable("DataPegawaiDataKinerja");
            builder.HasKey(x => x.DataPegawaiDataKinerjaId);
            builder.Property(x => x.NoUrutId).ValueGeneratedOnAdd();


        }
    }
}
