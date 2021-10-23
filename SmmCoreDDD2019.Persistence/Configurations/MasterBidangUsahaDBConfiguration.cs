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
    public class MasterBidangUsahaDBConfiguration : IEntityTypeConfiguration<MasterBidangUsahaDB>
    {
        public void Configure(EntityTypeBuilder<MasterBidangUsahaDB> builder)
        {
            builder.ToTable("MasterBidangUsahaDB");
          //  builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("MasterBidangUsahaDB_hilo").IsRequired();
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.NamaMasterBidangUsaha).HasColumnName("NamaMasterBidangUsaha")
              .HasMaxLength(200)
              .IsUnicode(false);

            builder.Property(e => e.TanggalInput).HasColumnName("TanggalInput").HasColumnType("datetime")
                 .HasDefaultValueSql("(getdate())");
        }
    }
}
