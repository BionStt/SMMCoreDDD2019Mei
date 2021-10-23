using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Persistence.Configurations
{
    public class DataPegawaiDataJabatanConfiguration : IEntityTypeConfiguration<DataPegawaiDataJabatan>
    {
        public void Configure(EntityTypeBuilder<DataPegawaiDataJabatan> builder)
        {
            builder.ToTable("DataPegawaiDataJabatan", "DataPegawai");

            //    builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("DataPegawaiDataJabatan_hilo").IsRequired();
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.DataPegawaiId);

            builder.Property(e => e.MasterJenisJabatanId);

            builder.Property(e => e.Keterangan).HasMaxLength(400).IsUnicode(false);

            builder.Property(e => e.TglBerhentiMenjabat).HasColumnType("datetime");

            builder.Property(e => e.TglMenjabat).HasColumnType("datetime").HasDefaultValueSql("(getdate())");


          }
    }
}
