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
    public class DataAccountConfiguration : IEntityTypeConfiguration<DataAccount>
    {
        public void Configure(EntityTypeBuilder<DataAccount> builder)
        {
            builder.ToTable("DataAccount");

            // builder.Property(e => e.Id)
            //     .ForSqlServerUseSequenceHiLo("AccountingDataAccount_hilo")
            //     .IsRequired();

            builder.Property(e => e.NoUrutId).ValueGeneratedOnAdd().IsRequired();

            builder.Property(e => e.Lft).HasColumnName("Lft").ValueGeneratedOnAddOrUpdate();
            builder.Property(e => e.Rgt).HasColumnName("Rgt").ValueGeneratedOnAddOrUpdate();
            builder.Property(e => e.Parent).HasColumnName("Parent").HasMaxLength(15);
            builder.Property(e => e.Depth).HasColumnName("Depth").ValueGeneratedOnAddOrUpdate();


            builder.Property(e => e.NormalPos).HasColumnName("NormalPos");
            builder.Property(e => e.KodeAccount).HasColumnName("KodeAccount").HasMaxLength(25);//perlu diubah ke 35
            builder.Property(e => e.Account).HasColumnName("Account").HasMaxLength(150).IsUnicode(false);
            //    builder.Property(e => e.Alias).HasColumnName("Alias").HasMaxLength(150).IsUnicode(false);
            builder.Property(e => e.NormalPos).HasColumnName("NormalPos");
            builder.Property(e => e.Kelompok).HasColumnName("Kelompok").HasMaxLength(2).IsUnicode(false);
            // builder.Property(e => e.DataMataUangId).HasColumnName("DataMataUangId");
        }
    }
}
