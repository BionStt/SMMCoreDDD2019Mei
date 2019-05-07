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
            builder.HasKey(e => e.NoUrut);

          
            builder.ToTable("DataSPKKreditDB", "DataSPKBaruDB");

            builder.Property(e=>e.NoUrut).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;

            //  builder.HasIndex(e => e.NoUrutSPKBaru);

            builder.Property(e => e.NoUrutSPKBaru).HasColumnName("NourutSPKBaru");
            builder.Property(e => e.NoUrutSPKBaru).ValueGeneratedNever();

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

            builder.HasOne(d => d.DataSPKBaruDB)
                .WithMany(p => p.DataSPKKreditDB)
                .HasForeignKey(d => d.NoUrutSPKBaru)
                 .OnDelete(DeleteBehavior.ClientSetNull)
         .HasConstraintName("FK_DataSPKKreditDB_DataSPKBaruDB"); ;

            // throw new NotImplementedException();
        }
    }
}
