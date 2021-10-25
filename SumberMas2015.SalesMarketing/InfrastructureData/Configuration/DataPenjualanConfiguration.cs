using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SumberMas2015.SalesMarketing.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.InfrastructureData.Configuration
{
    public class DataPenjualanConfiguration : IEntityTypeConfiguration<DataPenjualan>
    {
        public void Configure(EntityTypeBuilder<DataPenjualan> builder)
        {
            builder.ToTable("Penjualan");
            builder.Property(e => e.NoUrutId).ValueGeneratedOnAdd().IsRequired();
            builder.HasKey(e => e.DataPenjualanId);

            builder.Property(e => e.NoRegistrasiPenjualan).HasColumnName("NoRegistrasiPenjualan").HasMaxLength(50);
            builder.Property(e => e.DataSPKId);

            builder.Property(e => e.TanggalPenjualan).HasColumnType("datetime")
                 .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.DataKonsumenId);

            builder.Property(e => e.MasterLeasingCabangId);

            builder.Property(e => e.NoBuku)
                  .HasMaxLength(30)
                  .IsUnicode(false);

            builder.Property(e => e.SalesUserId).HasColumnName("SalesUserId");

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

            builder.Property(e => e.UserNameInput)
                .HasColumnName("UserNameInput")
                .HasMaxLength(20);

            builder.Property(e => e.UserInputId).HasColumnName("UserInputID");
        }
    }
}
