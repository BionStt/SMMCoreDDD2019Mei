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
    public class AccountingDataSaldoAwalConfiguration : IEntityTypeConfiguration<AccountingDataSaldoAwal>
    {
        public void Configure(EntityTypeBuilder<AccountingDataSaldoAwal> builder)
        {
            builder.ToTable("AccountingDataSaldoAwal", "Accounting");

            //builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("AccountingDataSaldoAwal_hilo").IsRequired();
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.AccountingDataPeriodeId);
            builder.Property(e => e.AccountingDataAccountId);
            builder.Property(e => e.Debet).HasColumnName("Debet").HasColumnType("money");
            builder.Property(e => e.Kredit).HasColumnName("Kredit").HasColumnType("money");
            builder.Property(e => e.Saldo).HasColumnName("Saldo").HasColumnType("money");
            builder.Property(e => e.AccountingDataMataUangId);
            builder.Property(e => e.UserInput).HasColumnName("UserInput").HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.NilaiKurs).HasColumnName("NilaiKurs").HasColumnType("money");


            builder.Property(e => e.TanggalInput)
              .HasColumnName("TanggalInput")
              .HasColumnType("datetime");


        }
    }
}
