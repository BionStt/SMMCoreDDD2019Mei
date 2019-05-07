using System;
using System.Collections.Generic;
using System.Text;


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmmCoreDDD2019.Domain.Entities;


namespace SmmCoreDDD2019.Persistence.Configurations
{
    public class DataSPKLeasingDBConfiguration : IEntityTypeConfiguration<DataSPKLeasingDB>
    {
        public void Configure(EntityTypeBuilder<DataSPKLeasingDB> builder)
        {

            builder.HasKey(e => e.NoUrut);

            builder.ToTable("DataSPKLeasingDB", "DataSPKBaruDB");
          

            builder.Property(e=>e.NoUrut).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;

            //builder.HasIndex(e => e.NoUrutLeasingCabang);

            //builder.HasIndex(e => e.NoUrutKategoriBayaran);

            //builder.HasIndex(e => e.NoUrutKategoriPenjualan);

            //   builder.HasIndex(e => e.NoUrutMarco);

            //builder.HasIndex(e => e.NoUrutSales);
            builder.Property(e=>e.NoUrutSales);

            builder.Property(e => e.Angsuran).HasColumnType("money");

            builder.Property(e => e.NoUrutLeasingCabang).HasColumnName("NoUrutLeasingCabang");

            builder.Property(e => e.Mediator)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.NamaCmo)
                .HasColumnName("NamaCMO")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.NoUrutKategoriPenjualan).HasColumnName("NoUrutKategoriPenjualan");

            builder.Property(e => e.NoUrutSPKBaru).HasColumnName("NoUrutSPKBaru");
            builder.Property(e => e.NoUrutSPKBaru).ValueGeneratedNever();

            builder.Property(e => e.Tenor).HasColumnName("tenor");

            builder.Property(e => e.TglSurvei).HasColumnType("datetime");

         
            //builder.HasOne(d => d.NoUrutMarcoNavigation)
            //    .WithMany(p => p.DataSpkleasingDb)
            //    .HasForeignKey(d => d.NoUrutMarco);

            //builder.HasOne(d => d.NoUrutSalesNavigation)
            //    .WithMany(p => p.DataSpkleasingDb)
            //    .HasForeignKey(d => d.NoUrutSales);

            builder.HasOne(d => d.MasterLeasingCabangDB)
                .WithMany(p => p.DataSPKLeasingDB)
                .HasForeignKey(d => d.NoUrutLeasingCabang)
                .HasConstraintName("FK_DataSPKLeasingDB_MasterLeasingDb");



            builder.HasOne(d => d.MasterKategoriBayaran)
                .WithMany(p => p.DataSPKLeasingDB)
                .HasForeignKey(d => d.NoUrutKategoriBayaran)
                .HasConstraintName("FK_DataSPKLeasingDB_MasterKategoriBayaran");

            builder.HasOne(d => d.MasterKategoriPenjualan)
                .WithMany(p => p.DataSPKLeasingDB)
                .HasForeignKey(d => d.NoUrutKategoriPenjualan)
                .HasConstraintName("FK_DataSPKLeasingDB_MasterKategoriPenjualan");

            builder.HasOne(d => d.DataSPKBaruDB)
                .WithMany(p => p.DataSPKLeasingDB)
                .HasForeignKey(d => d.NoUrutSPKBaru)
                 .OnDelete(DeleteBehavior.ClientSetNull)
               .HasConstraintName("FK_DataSPKLeasingDB_DataSPKBaruDB"); ;

            // throw new NotImplementedException();
        }
    }
}
