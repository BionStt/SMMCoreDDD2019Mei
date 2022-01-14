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
    public class DataSaldoAwalConfiguration : IEntityTypeConfiguration<DataSaldoAwal>
    {
        public void Configure(EntityTypeBuilder<DataSaldoAwal> builder)
        {
            builder.ToTable("DataSaldoAwal");

            // builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("AccountingDataSaldoAwal_hilo").IsRequired();
            builder.Property(e => e.NoUrutId).ValueGeneratedOnAdd().IsRequired();
            //  builder.Property(e => e.DataPeriodeId);
            builder.Property(e => e.DataAccountId);
            builder.Property(e => e.Debet).HasColumnName("Debet").HasColumnType("money");
            builder.Property(e => e.Kredit).HasColumnName("Kredit").HasColumnType("money");
            builder.Property(e => e.Saldo).HasColumnName("Saldo").HasColumnType("money");
            // builder.Property(e => e.DataMataUangId);
            //  builder.Property(e => e.UserInput).HasColumnName("UserInput").HasMaxLength(50).IsUnicode(false);
            //  builder.Property(e => e.NilaiKurs).HasColumnName("NilaiKurs").HasColumnType("money");


            builder.Property(e => e.TanggalInput)
                .HasColumnName("TanggalInput")
                .HasColumnType("datetime").HasDefaultValue(DateTime.Now);



        }
    }
}
