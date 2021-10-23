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
    public class MasterBidangPekerjaanDBConfiguration : IEntityTypeConfiguration<MasterBidangPekerjaanDB>
    {
        public void Configure(EntityTypeBuilder<MasterBidangPekerjaanDB> builder)
        {
            builder.ToTable("MasterBidangPekerjaanDB");
          //  builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("MasterBidangPekerjaanDB_hilo").IsRequired();
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.NamaMasterBidangPekerjaan).HasColumnName("NamaMasterBidangPekerjaan")
              .HasMaxLength(200)
              .IsUnicode(false);

            builder.Property(e => e.TanggalInput).HasColumnName("TanggalInput").HasColumnType("datetime")
                 .HasDefaultValueSql("(getdate())");


        }
    }
}
