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
    public class AccountingDataJournalHeaderConfiguration : IEntityTypeConfiguration<AccountingDataJournalHeader>
    {
        public void Configure(EntityTypeBuilder<AccountingDataJournalHeader> builder)
        {
            builder.ToTable("AccountingDataJournalHeader", "Accounting");

            // builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("AccountingDataJournalHeader_hilo").IsRequired();
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.TanggalInput)
              .HasColumnName("TanggalInput")
              .HasColumnType("datetime");

            builder.Property(e => e.NoBuktiJournal).HasColumnName("NoBuktiJournal").HasMaxLength(40).IsUnicode(false);
            builder.Property(e => e.Keterangan).HasColumnName("Keterangan").HasMaxLength(500);
            builder.Property(e => e.AccountingTipeJournalId);
            builder.Property(e => e.UserInput).HasColumnName("UserInput").HasMaxLength(40).IsUnicode(false);
            builder.Property(e => e.Validasi).HasColumnName("Validasi").HasColumnType("datetime");
            builder.Property(e => e.ValidasiOleh).HasColumnName("ValidasiOleh").HasMaxLength(40).IsUnicode(false);
            builder.Property(e => e.Aktif).HasColumnName("Aktif").HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.AccountingDataPeriodeId);


        }
    }
}
