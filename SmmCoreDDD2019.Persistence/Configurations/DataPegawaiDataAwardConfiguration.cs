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
    public class DataPegawaiDataAwardConfiguration : IEntityTypeConfiguration<DataPegawaiDataAward>
    {
        public void Configure(EntityTypeBuilder<DataPegawaiDataAward> builder)
        {
            builder.ToTable("DataPegawaiDataAward", "DataPegawai");
          //  builder.Property(e=>e.Id).ForSqlServerUseSequenceHiLo("DataPegawaiDataAward_hilo").IsRequired();
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

        }
    }
}
