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
    public class DataSPKKreditConfiguration : IEntityTypeConfiguration<DataSPKKredit>
    {
        public void Configure(EntityTypeBuilder<DataSPKKredit> builder)
        {
            builder.ToTable("DataSPKKredit");
            builder.HasKey(e => e.DataSPKKreditId);
            builder.Property(e => e.NoUrutId).ValueGeneratedOnAdd();

            builder.Property(e => e.BiayaAdministrasiKredit).HasColumnType("money");
            builder.Property(e => e.BiayaAdministrasiTunai).HasColumnType("money");
            builder.Property(e => e.BBN).HasColumnType("money");
            builder.Property(e => e.DendaWilayah).HasColumnType("money");
            builder.Property(e => e.DiskonDP).HasColumnType("money");
            builder.Property(e => e.DiskonTunai).HasColumnType("money");
            builder.Property(e => e.DPPriceList).HasColumnType("money");
            builder.Property(e => e.Komisi).HasColumnType("money");
            builder.Property(e => e.Komisi).HasColumnType("money");
            builder.Property(e => e.OffTheRoad).HasColumnType("money");
            builder.Property(e => e.Promosi).HasColumnType("money");
            builder.Property(e => e.UangTandaJadiTunai).HasColumnType("money");
            builder.Property(e => e.UangTandaJadiKredit).HasColumnType("money");
        }
    }
}
