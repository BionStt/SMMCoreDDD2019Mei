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
    public class MasterPerusahaanAsuransiPegawaiConfiguration : IEntityTypeConfiguration<MasterPerusahaanAsuransiPegawai>
    {
        public void Configure(EntityTypeBuilder<MasterPerusahaanAsuransiPegawai> builder)
        {
            builder.ToTable("MasterPerusahaanAsuransiPegawai");
            builder.HasKey(x => x.MasterPerusahaanAsuransiPegawaiId);
            builder.Property(x => x.NoUrutId).ValueGeneratedOnAdd();



        }
    }
}
