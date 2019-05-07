using System;
using System.Collections.Generic;
using System.Text;


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Persistence.Configurations
{
    class DataSPKSurveiDBConfiguration : IEntityTypeConfiguration<DataSPKSurveiDB>
    {
        public void Configure(EntityTypeBuilder<DataSPKSurveiDB> builder)
        {
            builder.HasKey(e => e.NoUrut);

            builder.ToTable("DataSPKSurveiDB", "DataSPKBaruDB");

          

            builder.Property(e=>e.NoUrut).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;

            builder.Property(e => e.AlamatPemesan)
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.HandphonePemesan)
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.KecamatanPemesan)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.KelurahanPemesan)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.KodePosPemesan)
                .HasMaxLength(7)
                .IsUnicode(false);

            builder.Property(e => e.KotaPemesan)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.NamaNPWP)
                .HasColumnName("NamaNPWP")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.NamaPemesan)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.NoKtpPemesan)
                .HasMaxLength(25)
                .IsUnicode(false);

            builder.Property(e => e.NoNPWP)
                .HasColumnName("NoNPWP")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.NoUrutSPKBaru).HasColumnName("NoUrutSPKBaru");
            builder.Property(e => e.NoUrutSPKBaru).ValueGeneratedNever();

            builder.Property(e => e.PekerjaanPemesan)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.PropinsiPemesan)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.TelpPemesan)
                .HasMaxLength(18)
                .IsUnicode(false);

            builder.HasOne(d => d.DataSPKBaruDB)
              .WithMany(p => p.DataSPKSurveiDB)
              .HasForeignKey(d => d.NoUrutSPKBaru)
               .OnDelete(DeleteBehavior.ClientSetNull)
             .HasConstraintName("FK_DataSPKSurveiDB_DataSPKBaruDB"); ;


            // throw new NotImplementedException();
        }
    }
}
