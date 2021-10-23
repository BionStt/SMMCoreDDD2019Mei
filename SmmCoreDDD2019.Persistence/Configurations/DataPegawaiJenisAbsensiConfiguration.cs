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
    public class DataPegawaiJenisAbsensiConfiguration : IEntityTypeConfiguration<DataPegawaiJenisAbsensi>
    {
        public void Configure(EntityTypeBuilder<DataPegawaiJenisAbsensi> builder)
        {
            builder.ToTable("DataPegawaiJenisAbsensi", "DataPegawai");
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            //builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("DataPegawaiJenisAbsensi_hilo").IsRequired();
         builder.Property(e => e.JenisAbsensi).HasColumnName("JenisAbsensi").HasMaxLength(100).IsUnicode(false);
            builder.Property(e => e.Keterangan).HasColumnName("Keterangan").HasMaxLength(100).IsUnicode(false);
            builder.Property(e => e.JamMulai).HasColumnName("JamMulai").HasColumnType("datetime");
            builder.Property(e => e.JamBerakhir).HasColumnName("JamBerakhir").HasColumnType("datetime");


        }
    }
}
