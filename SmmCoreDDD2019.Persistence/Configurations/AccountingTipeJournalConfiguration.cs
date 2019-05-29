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
    public class AccountingTipeJournalConfiguration : IEntityTypeConfiguration<AccountingTipeJournal>
    {
        public void Configure(EntityTypeBuilder<AccountingTipeJournal> builder)
        {
            builder.ToTable("AccountingTipeJournal", "Accounting");

            builder.HasKey(e => e.NoIDTipeJournal);
            builder.Property(e => e.NoIDTipeJournal).HasColumnName("NoIDTipeJournal");
            builder.Property(e => e.NoIDTipeJournal).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;

            builder.Property(e => e.KodeJournal)
               .HasMaxLength(10)
              .IsUnicode(false);

            builder.Property(e => e.NamaJournal)
              .HasColumnName("NamaJournal")
              .HasMaxLength(50)
              .IsUnicode(false);
        }
    }
}