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

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

             //  builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("DataPegawaiDataAbsensi_hilo").IsRequired();
             builder.Property(e => e.DataPegawaiId);
            builder.Property(e => e.DataPegawaiJenisAbsensiId);
            builder.Property(e => e.JamAbsensi).HasColumnName("JamAbsensi").HasColumnType("datetime");

        }
    }
}
