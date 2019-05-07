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

            builder.HasKey(e => e.NoUrutJournalH);
            builder.Property(e => e.NoUrutJournalH).HasColumnName("NoUrutJournalH");
            builder.Property(e => e.NoUrutJournalH).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;

            builder.Property(e => e.TanggalInput)
              .HasColumnName("TanggalInput")
              .HasColumnType("datetime");

            builder.Property(e => e.NoBuktiJournal).HasColumnName("NoBuktiJournal").HasMaxLength(40).IsUnicode(false);
            builder.Property(e => e.Keterangan).HasColumnName("Keterangan").HasMaxLength(500);
            builder.Property(e => e.NoIDTipeJournal).HasColumnName("NoIDTipeJournal").HasMaxLength(3).IsUnicode(false);
            builder.Property(e => e.UserInput).HasColumnName("UserInput").HasMaxLength(40).IsUnicode(false);
            builder.Property(e => e.Validasi).HasColumnName("Validasi").HasColumnType("datetime");
            builder.Property(e => e.ValidasiOleh).HasColumnName("ValidasiOleh").HasMaxLength(40).IsUnicode(false);
            builder.Property(e => e.Aktif).HasColumnName("Aktif").HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.NoUrutPeriodeID).HasColumnName("NoUrutPeriodeID").HasMaxLength(4).IsUnicode(false);

           
        }
    }
}
