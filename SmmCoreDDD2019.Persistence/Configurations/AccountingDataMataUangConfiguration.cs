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
    public class AccountingDataMataUangConfiguration : IEntityTypeConfiguration<AccountingDataMataUang>
    {
      

        public void Configure(EntityTypeBuilder<AccountingDataMataUang> builder)
        {
            builder.ToTable("AccountingDataMataUang", "Accounting");

             builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("AccountingDataMataUang_hilo").IsRequired();


           builder.Property(e => e.Kode).HasColumnName("Kode").HasMaxLength(10).IsUnicode(false);
            builder.Property(e => e.Nama).HasColumnName("Nama").HasMaxLength(50).IsUnicode(false);

          
        }
    }
}
