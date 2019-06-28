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
    public class PembelianConfiguration : IEntityTypeConfiguration<Pembelian>
    {
        public void Configure(EntityTypeBuilder<Pembelian> builder)
        {
            builder.ToTable("Pembelian", "Pembelian");

            builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("Pembelian_hilo").IsRequired();
           
            builder.Property(e=>e.NoRegistrasiPembelian).HasColumnName("NoRegistrasiPembelian").HasMaxLength(50);

            builder.Property(e => e.TglBeli).HasColumnType("datetime")
                  .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.MasterSupplierDBId);

            builder.Property(e => e.JenisTransPmb)
             .HasMaxLength(1)
             .IsUnicode(false);

            builder.Property(e => e.Kredit)
             .HasMaxLength(3)
             .IsUnicode(false);

            builder.Property(e => e.Keterangan)
              .HasMaxLength(250)
              .IsUnicode(false);


            builder.Property(e => e.Batal)
                .HasMaxLength(1)
                .IsUnicode(false);

            builder.Property(e => e.UserInput).HasMaxLength(50).IsUnicode(false);

            builder.Property(e => e.UserInputId).HasColumnName("UserInputId");

            builder.Property(e => e.PembelianPOId);

         

          
        }
    }
}
