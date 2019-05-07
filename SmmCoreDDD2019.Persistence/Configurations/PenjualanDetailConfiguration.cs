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
            builder.HasKey(e => e.NoPenjualanDetail);
        
            builder.Property(e => e.NoPenjualanDetail).HasColumnName("NoPenjualanDetail");
            builder.Property(e => e.NoPenjualanDetail).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;

            builder.Property(e => e.KodePenjualan).HasColumnName("KodePenjualan");

            builder.Property(e => e.NoUrutSO).HasColumnName("NoUrutSO");

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
