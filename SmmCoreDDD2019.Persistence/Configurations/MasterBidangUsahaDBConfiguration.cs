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
            builder.HasKey(e => e.NoKodeMasterBidangUsaha);
            builder.Property(e => e.NoKodeMasterBidangUsaha).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;

            builder.ToTable("MasterBidangUsahaDB");

            builder.Property(e => e.NoKodeMasterBidangUsaha).HasColumnName("NoKodeMasterBidangUsaha");

            builder.Property(e => e.NamaMasterBidangUsaha).HasColumnName("NamaMasterBidangUsaha")
              .HasMaxLength(200)
              .IsUnicode(false);

            builder.Property(e => e.TanggalInput).HasColumnName("TanggalInput").HasColumnType("datetime")
                 .HasDefaultValueSql("(getdate())");
        }
    }
}
