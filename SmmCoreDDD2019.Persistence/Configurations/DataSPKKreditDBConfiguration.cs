using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmmCoreDDD2019.Domain.Entities;


namespace SmmCoreDDD2019.Persistence.Configurations
{
    public class DataSPKKreditDBConfiguration : IEntityTypeConfiguration<DataSPKKreditDB>
    {
        public void Configure(EntityTypeBuilder<DataSPKKreditDB> builder)
        {
            builder.ToTable("DataSPKKreditDB", "DataSPKBaruDB");
            builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("DataSPKKreditDB_hilo").IsRequired();
         
            builder.Property(e => e.DataSPKBaruDBId);

            builder.Property(e => e.BiayaAdministrasiKredit).HasColumnType("money");

            builder.Property(e => e.BiayaAdministrasiTunai).HasColumnType("money");

            builder.Property(e => e.BBN)
                .HasColumnName("BBN")
                .HasColumnType("money");

            builder.Property(e => e.DendaWilayah).HasColumnType("money");

            builder.Property(e => e.DiskonDP)
                .HasColumnName("DiskonDP")
                .HasColumnType("money");

            builder.Property(e => e.DiskonTunai).HasColumnType("money");

            builder.Property(e => e.DPPriceList)
                .HasColumnName("DPPricelist")
                .HasColumnType("money");

            builder.Property(e => e.Komisi).HasColumnType("money");


            builder.Property(e => e.OffTheRoad).HasColumnType("money");

            builder.Property(e => e.Promosi).HasColumnType("money");

            builder.Property(e => e.UangTandaJadiTunai).HasColumnType("money");

            builder.Property(e => e.UangTandaJadiKredit).HasColumnType("money");

       
        }
    }
}
