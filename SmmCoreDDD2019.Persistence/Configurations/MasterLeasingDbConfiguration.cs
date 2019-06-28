using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Persistence.Configurations
{
    public class MasterLeasingDbConfiguration : IEntityTypeConfiguration<MasterLeasingDb>
    {
        public void Configure(EntityTypeBuilder<MasterLeasingDb> builder)
        {
            builder.ToTable("MasterLeasingDB", "MasterLeasingDB");
            builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("MasterLeasingDB_hilo").IsRequired();
                  
            builder.Property(e => e.NamaLease).HasMaxLength(50)
                .IsUnicode(false);

          //  throw new NotImplementedException();
        }
    }
}
