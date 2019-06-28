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
    public class PembelianPODetailConfiguration : IEntityTypeConfiguration<PembelianPODetail>
    {
        public void Configure(EntityTypeBuilder<PembelianPODetail> builder)
        {

            builder.ToTable("PembelianPODetail", "PembelianPO");
            builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("PembelianPODetail_hilo").IsRequired();
      
            builder.Property(e=>e.MasterBarangDBId);

            builder.Property(e => e.OffTheRoad).HasColumnType("money");

            builder.Property(e => e.Bbn)
                .HasColumnName("BBn")
                .HasColumnType("money");

            builder.Property(e => e.Diskon).HasColumnType("money");

            builder.Property(e => e.Warna)
              .HasColumnName("Warna")
              .HasMaxLength(40)
              .IsUnicode(false);

            builder.Property(e=>e.Qty).HasColumnName("Qty");

            builder.Property(e => e.Keterangan)
                .HasMaxLength(200)
                .IsUnicode(false);

          

          

          
        }
    }
}
