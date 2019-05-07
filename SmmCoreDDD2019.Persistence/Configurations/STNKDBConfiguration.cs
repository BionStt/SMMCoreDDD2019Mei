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
    public class STNKDBConfiguration : IEntityTypeConfiguration<STNKDB>
    {
        public void Configure(EntityTypeBuilder<STNKDB> builder)
        {
            builder.HasKey(e => e.NoUrutStnk);

            builder.ToTable("STNKDB","Penjualan");

            builder.Property(e => e.NoUrutStnk).HasColumnName("NoUrutSTNK");
            builder.Property(e => e.NoUrutStnk).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;

            builder.Property(e => e.BbnPabrik)
                .HasColumnName("BBnPabrik")
                .HasColumnType("money");

            builder.Property(e => e.NoUrutFaktur).HasColumnName("NoUrutFaktur");

            builder.Property(e => e.BiayaTambahan).HasColumnType("money");

            builder.Property(e => e.Birojasa).HasColumnType("money");

            builder.Property(e => e.FormA).HasColumnType("money");

         
            builder.Property(e => e.NomorPlat)
                .HasMaxLength(12)
                .IsUnicode(false);

            builder.Property(e => e.NoStnk)
                .HasColumnName("NoSTNK")
                .HasMaxLength(25)
                .IsUnicode(false);

            builder.Property(e => e.PajakStnk).HasColumnType("money");

            builder.Property(e => e.Perwil).HasColumnType("money");

            builder.Property(e => e.PajakProgresif).HasColumnType("money");

            builder.Property(e => e.TanggalBayarSTNK)
                .HasColumnName("TanggalBayarSTNK")
                .HasColumnType("datetime");

         
        }
    }
}
