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
    public class AccountingDataKursConfiguration : IEntityTypeConfiguration<AccountingDataKurs>
    {
        public void Configure(EntityTypeBuilder<AccountingDataKurs> builder)
        {
            builder.ToTable("AccountingDataKurs", "Accounting");

            builder.HasKey(e => e.NoUrutKursID);
            builder.Property(e => e.NoUrutKursID).HasColumnName("NoUrutKursID");
            builder.Property(e => e.NoUrutKursID).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;

            builder.Property(e => e.MataUangID).HasColumnName("MataUangID").HasMaxLength(3).IsUnicode(false);

            builder.Property(e => e.TanggalInput)
              .HasColumnName("TanggalInput")
              .HasColumnType("datetime");

            builder.Property(e => e.Nilai).HasColumnName("Nilai").HasColumnType("money");
          
        }
    }
}
