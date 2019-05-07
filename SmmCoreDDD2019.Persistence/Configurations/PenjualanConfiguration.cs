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
    public class PenjualanConfiguration : IEntityTypeConfiguration<Penjualan>
    {
        public void Configure(EntityTypeBuilder<Penjualan> builder)
        {
            builder.HasKey(e => e.KodePenjualan);
            builder.ToTable("Penjualan", "Penjualan");
            builder.Property(e => e.KodePenjualan).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;

            builder.Property(e=>e.NoRegistrasiPenjualan).HasColumnName("NoRegistrasiPenjualan").HasMaxLength(50);
            builder.Property(e => e.NoUrutSPK).HasColumnName("NoUrutSPK");

            builder.Property(e => e.TanggalPenjualan).HasColumnType("datetime")
                 .HasDefaultValueSql("(getdate())"); 

            builder.Property(e=>e.KodeKonsumen).HasColumnName("KodeKonsumen");

            builder.Property(e => e.KodeLease).HasColumnName("KodeLease");

            builder.Property(e => e.NoBuku)
                  .HasMaxLength(30)
                  .IsUnicode(false);

            builder.Property(e => e.NoUrutSales).HasColumnName("NoUrutSales");

            builder.Property(e => e.Keterangan)
                .HasMaxLength(300)
                .IsUnicode(false);

            builder.Property(e => e.Batal)
                .HasMaxLength(1)
                .IsUnicode(false);

            builder.Property(e=>e.KategoriPenjualan).HasColumnName("KategoriPenjualan");

          builder.Property(e => e.Mediator)
                .HasMaxLength(15)
                .IsUnicode(false);

            builder.Property(e => e.UserInput)
                .HasColumnName("USerInput")
                .HasMaxLength(20);

            builder.Property(e => e.UserInputId).HasColumnName("UserInputID");
        }
    }
}
