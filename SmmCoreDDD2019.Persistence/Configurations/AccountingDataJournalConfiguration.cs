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

            builder.Property(e=>e.Id).ForSqlServerUseSequenceHiLo("AccountingDataJournal_hilo").IsRequired();
            builder.Property(e => e.AccountingDataJournalHeaderId);
            builder.Property(e => e.AccountingDataAccountId);
            builder.Property(e => e.Debit).HasColumnName("Debit").HasColumnType("money");
            builder.Property(e => e.Kredit).HasColumnName("Kredit").HasColumnType("money");
            builder.Property(e => e.Keterangan).HasColumnName("Keterangan").HasMaxLength(400).IsUnicode(false);

        
        }
    }
}
