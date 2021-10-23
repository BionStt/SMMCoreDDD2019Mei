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
    public class PenjualanDetailConfiguration : IEntityTypeConfiguration<PenjualanDetail>
    {
        public void Configure(EntityTypeBuilder<PenjualanDetail> builder)
        {
            builder.ToTable("PenjualanDetail", "Penjualan");
           // builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("PenjualanDetail_hilo").IsRequired();
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.PenjualanId);

            builder.Property(e => e.StokUnitId);

            builder.Property(e => e.OffTheRoad)
             .HasColumnName("OffTheRoad")
             .HasColumnType("money");

            builder.Property(e => e.BBN)
                .HasColumnName("BBN")
                .HasColumnType("money");

            builder.Property(e => e.HargaOTR)
                  .HasColumnName("HargaOTR")
                  .HasColumnType("money");

            builder.Property(e => e.UangMuka).HasColumnType("money");

            builder.Property(e => e.DiskonKredit).HasColumnType("money");

           builder.Property(e => e.DiskonTunai).HasColumnType("money");

            builder.Property(e => e.Subsidi).HasColumnType("money");

            builder.Property(e => e.Promosi).HasColumnType("money");

            builder.Property(e => e.Komisi).HasColumnType("money");

         builder.Property(e => e.JoinPromo1).HasColumnType("money");

            builder.Property(e => e.JoinPromo2).HasColumnType("money");

            builder.Property(e => e.SPF)
                    .HasColumnName("SPF")
                    .HasColumnType("money");

            builder.Property(e => e.SellOut).HasColumnType("money");

            builder.Property(e => e.DendaWilayah).HasColumnType("money");

            builder.Property(e => e.CheckDp)
             .HasColumnName("CheckDP")
             .HasMaxLength(1)
             .IsUnicode(false);

            builder.Property(e => e.TanggalCheckLapBulanan).HasColumnType("datetime");

            builder.Property(e => e.UserCheckLapBulanan).HasColumnName("UserCheckLapBulanan").HasMaxLength(50);

            builder.Property(e => e.CheckLapBulanan)
          .HasColumnName("CheckLapBulanan")
          .HasMaxLength(1)
          .IsUnicode(false);


        }
    }
}
