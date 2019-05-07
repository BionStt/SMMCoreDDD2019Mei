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
    public class AccountingDataAccountConfiguration : IEntityTypeConfiguration<AccountingDataAccount>
    {
        public void Configure(EntityTypeBuilder<AccountingDataAccount> builder)
        {
            builder.ToTable("AccountingDataAccount", "Accounting");

            builder.HasKey(e => e.NoUrutAccountId);
            builder.Property(e => e.NoUrutAccountId).HasColumnName("NoUrutAccountId");
            builder.Property(e => e.NoUrutAccountId).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;
            

            builder.Property(e=>e.Lft).HasColumnName("Lft").ValueGeneratedOnAddOrUpdate();
            builder.Property(e => e.Rgt).HasColumnName("Rgt").ValueGeneratedOnAddOrUpdate();
            builder.Property(e => e.Parent).HasColumnName("Parent").HasMaxLength(15);
            builder.Property(e => e.Depth).HasColumnName("Depth").ValueGeneratedOnAddOrUpdate();
         

            builder.Property(e => e.NormalPos).HasColumnName("NormalPos");
            builder.Property(e => e.KodeAccount).HasColumnName("KodeAccount").HasMaxLength(25);
            builder.Property(e => e.Account).HasColumnName("Account").HasMaxLength(150).IsUnicode(false);
            builder.Property(e => e.NormalPos).HasColumnName("NormalPos");
            builder.Property(e => e.Kelompok).HasColumnName("Kelompok").HasMaxLength(2).IsUnicode(false);
            builder.Property(e => e.MataUangID).HasColumnName("MataUangID").HasMaxLength(4).IsUnicode(false);
        }
    }
}
