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
    public class DataPegawaiAbsensiConfiguration : IEntityTypeConfiguration<DataPegawaiAbsensi>
    {
        public void Configure(EntityTypeBuilder<DataPegawaiAbsensi> builder)
        {
            builder.ToTable("DataPegawaiAbsensi");
            builder.Property(x => x.NoUrutId).ValueGeneratedOnAdd();
            builder.HasKey(x => x.DataPegawaiAbsensiId);



        }
    }
}
