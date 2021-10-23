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
    public class PembelianPOConfiguration : IEntityTypeConfiguration<PembelianPO>
    {
        public void Configure(EntityTypeBuilder<PembelianPO> builder)
        {
            builder.ToTable("PembelianPO", "PembelianPO");
            //  builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("PembelianPO_hilo").IsRequired();
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e=>e.NoRegistrasiPoPMB).HasColumnName("NoRegistrasiPoPMB").HasMaxLength(50);

          builder.Property(e => e.MasterSupplierDBId);

            builder.Property(e => e.Keterangan)
                .HasMaxLength(300)
                .IsUnicode(false);

            builder.Property(e => e.Terinput)
              .HasMaxLength(1)
              .IsUnicode(false);

            builder.Property(e => e.UserId).HasColumnName("UserId");

            builder.Property(e => e.UserInput)
             .HasMaxLength(30)
             .IsUnicode(false);

            builder.Property(e => e.PoAstra)
                .HasMaxLength(25)
                .IsUnicode(false);

            builder.Property(e => e.TglPo)
                .HasColumnName("TglPo")
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");



        }
    }
}
