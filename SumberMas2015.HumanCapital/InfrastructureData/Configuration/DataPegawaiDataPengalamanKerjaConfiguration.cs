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
    public class DataPegawaiDataPengalamanKerjaConfiguration : IEntityTypeConfiguration<DataPegawaiDataPengalamanKerja>
    {
        public void Configure(EntityTypeBuilder<DataPegawaiDataPengalamanKerja> builder)
        {
            builder.ToTable("");
            builder.Property(x => x.NoUrutId).ValueGeneratedOnAdd();
            builder.HasKey(x => x.DataPegawaiDataPengalamanKerjaId);


        }
    }
}
