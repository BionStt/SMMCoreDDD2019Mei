﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmmCoreDDD2019.Domain.Entities;
namespace SmmCoreDDD2019.Persistence.Configurations
{
    public class AccountingDataBuktiTransaksiConfiguration : IEntityTypeConfiguration<AccountingDataBuktiTransaksi>
    {
        public void Configure(EntityTypeBuilder<AccountingDataBuktiTransaksi> builder)
        {
            builder.ToTable("AccountingDataBuktiTransaksi", "Accounting");

            builder.HasKey(e => e.NoUrutBuktiTransaksi);
            builder.Property(e => e.NoUrutBuktiTransaksi).HasColumnName("NoUrutBuktiTransaksi");
            builder.Property(e => e.NoUrutBuktiTransaksi).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;

            builder.Property(e => e.TipeJournal).HasColumnName("TipeJournal");
            builder.Property(e => e.NoBukti).HasColumnName("NoBukti");

            builder.Property(e => e.TanggalInput)
              .HasColumnName("TanggalInput")
              .HasColumnType("datetime");

            builder.Property(e => e.Keterangan).HasColumnName("Keterangan");
            builder.Property(e => e.ValidateBy).HasColumnName("ValidateBy");

            builder.Property(e => e.ValidatedDate)
              .HasColumnName("ValidatedDate")
              .HasColumnType("datetime");

            builder.Property(e => e.Total)
              .HasColumnName("Total")
              .HasColumnType("money");
        }
    }
}