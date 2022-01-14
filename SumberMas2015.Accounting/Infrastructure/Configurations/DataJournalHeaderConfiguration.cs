using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SumberMas2015.Accounting.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Accounting.Infrastructure.Configurations
{
    public class DataJournalHeaderConfiguration : IEntityTypeConfiguration<DataJournalHeader>
    {
        public void Configure(EntityTypeBuilder<DataJournalHeader> builder)
        {
            builder.ToTable("DataJournalHeader");

            //builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("AccountingDataJournalHeader_hilo").IsRequired();

            builder.Property(e => e.NoUrutId).ValueGeneratedOnAdd().IsRequired();
            //builder.Property(e => e.TanggalInput)
            //    .HasColumnName("TanggalInput")
            //    .HasColumnType("datetime").HasDefaultValue("getdate()");

            builder.Property(e => e.NoBuktiJournal).HasColumnName("NoBuktiJournal").HasMaxLength(40).IsUnicode(false);
            builder.Property(e => e.TotalRupiah).HasColumnType("money");
            builder.Property(e => e.Keterangan).HasColumnName("Keterangan").HasMaxLength(500);
            builder.Property(e => e.TipeJournalId);
            builder.Property(e => e.UserInput).HasColumnName("UserInput").HasMaxLength(40).IsUnicode(false);
            builder.Property(e => e.Validasi).HasColumnName("Validasi").HasColumnType("datetime");
            builder.Property(e => e.ValidasiOleh).HasColumnName("ValidasiOleh").HasMaxLength(40).IsUnicode(false);
            builder.Property(e => e.Aktif).HasColumnName("Aktif").HasMaxLength(2).IsUnicode(false);
            //  builder.Property(e => e.DataPeriodeId);
        }
    }
}
