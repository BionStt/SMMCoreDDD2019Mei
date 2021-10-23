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
            builder.ToTable("Penjualan", "Penjualan");
            //  builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo().IsRequired();
            builder.Property(e => e.Id).ValueGeneratedOnAdd();


            builder.Property(e=>e.NoRegistrasiPenjualan).HasColumnName("NoRegistrasiPenjualan").HasMaxLength(50);
            builder.Property(e => e.DataSPKBaruDBId);

            builder.Property(e => e.TanggalPenjualan).HasColumnType("datetime")
                 .HasDefaultValueSql("(getdate())");

            builder.Property(e=>e.CustomerDBId);

            builder.Property(e => e.MasterLeasingCabangDBId);

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

            builder.Property(e => e.MasterKategoriPenjualanId);

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
