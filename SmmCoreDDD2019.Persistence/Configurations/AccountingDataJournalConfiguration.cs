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
    public class AccountingDataJournalConfiguration : IEntityTypeConfiguration<AccountingDataJournal>
    {
        public void Configure(EntityTypeBuilder<AccountingDataJournal> builder)
        {
            builder.ToTable("AccountingDataJournal", "Accounting");

            builder.HasKey(e => e.JournalID);
            builder.Property(e => e.JournalID).HasColumnName("JournalID");
            builder.Property(e => e.JournalID).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;

            builder.Property(e => e.NoUrutJournalH).HasColumnName("NoUrutJournalH").HasMaxLength(10);
            builder.Property(e => e.NoUrutAccountId).HasColumnName("NoUrutAccountId").HasMaxLength(5);
            builder.Property(e => e.Debit).HasColumnName("Debit").HasColumnType("money");
            builder.Property(e => e.Kredit).HasColumnName("Kredit").HasColumnType("money");
            builder.Property(e => e.Keterangan).HasColumnName("Keterangan").HasMaxLength(400).IsUnicode(false);

        
        }
    }
}
