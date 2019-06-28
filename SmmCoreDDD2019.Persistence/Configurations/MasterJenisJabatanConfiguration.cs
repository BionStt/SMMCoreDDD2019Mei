using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Persistence.Configurations
{
    public class MasterJenisJabatanConfiguration : IEntityTypeConfiguration<MasterJenisJabatan>
    {
        public void Configure(EntityTypeBuilder<MasterJenisJabatan> builder)
        {
            builder.ToTable("MasterJenisJabatan");
            builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("MasterJenisJabatan_hilo").IsRequired();
       
            builder.Property(e => e.NamaJabatan)
                .HasMaxLength(50)
                .IsUnicode(false);


            //  throw new NotImplementedException();
        }
    }
}
