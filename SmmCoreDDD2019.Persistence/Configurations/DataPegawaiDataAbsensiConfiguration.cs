using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Persistence.Configurations
{
    public class DataPegawaiDataAbsensiConfiguration : IEntityTypeConfiguration<DataPegawaiDataAbsensi>
    {
        public void Configure(EntityTypeBuilder<DataPegawaiDataAbsensi> builder)
        {
            builder.ToTable("DataPegawaiDataAbsensi", "DataPegawai");

            builder.HasKey(e => e.NoUrutAbsensi);
            builder.Property(e => e.NoUrutAbsensi).HasColumnName("NoUrutAbsensi");
            builder.Property(e => e.NoUrutAbsensi).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;

            builder.Property(e=>e.IDPegawai).HasColumnName("IDPegawai");
            builder.Property(e => e.NoUrutJenisAbsensi).HasColumnName("NoUrutJenisAbsensi").HasMaxLength(3);
            builder.Property(e => e.JamAbsensi).HasColumnName("JamAbsensi").HasColumnType("datetime");
           
        }
    }
}
