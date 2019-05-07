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

            builder.HasKey(e => e.MataUangID);
            builder.Property(e => e.MataUangID).HasColumnName("MataUangID");
            builder.Property(e => e.MataUangID).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;

            builder.Property(e => e.Kode).HasColumnName("Kode").HasMaxLength(10).IsUnicode(false);
            builder.Property(e => e.Nama).HasColumnName("Nama").HasMaxLength(50).IsUnicode(false);

          
        }
    }
}
