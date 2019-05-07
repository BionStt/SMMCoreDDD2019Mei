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
    public class BPKBDBConfiguration : IEntityTypeConfiguration<BPKBDB>
    {
        public void Configure(EntityTypeBuilder<BPKBDB> builder)
        {
            builder.ToTable("BPKBDB", "Penjualan");
            builder.HasKey(e => e.NoUrutBPKB);
            builder.Property(e => e.NoUrutBPKB).HasColumnName("NoUrutBPKB");
            builder.Property(e => e.NoUrutBPKB).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;

            builder.Property(e => e.TanggalTerimaBPKB)
              .HasColumnName("TglTerimaBPKB")
              .HasColumnType("datetime");

            builder.Property(e => e.NoBpkb)
              .HasColumnName("NoBPKB")
              .HasMaxLength(20)
              .IsUnicode(false);
        }
    }
}
