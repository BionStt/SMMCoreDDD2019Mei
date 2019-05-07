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
    public class AccountingDataPeriodeConfiguration : IEntityTypeConfiguration<AccountingDataPeriode>
    {
        public void Configure(EntityTypeBuilder<AccountingDataPeriode> builder)
        {
            builder.ToTable("AccountingDataPeriode", "Accounting");

            builder.HasKey(e => e.NoUrutPeriodeID);
            builder.Property(e => e.NoUrutPeriodeID).HasColumnName("NoUrutPeriodeID");
            builder.Property(e => e.NoUrutPeriodeID).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;

            builder.Property(e => e.Mulai)
              .HasColumnName("Mulai")
              .HasColumnType("datetime");

            builder.Property(e => e.Berakhir)
           .HasColumnName("Berakhir")
           .HasColumnType("datetime");
            builder.Property(e => e.IsAktif).HasColumnName("IsAktif").HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.UserInput).HasColumnName("UserInput").HasMaxLength(50).IsUnicode(false);

        }
    }
}
