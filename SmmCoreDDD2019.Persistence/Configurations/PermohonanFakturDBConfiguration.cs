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
    public class PermohonanFakturDBConfiguration : IEntityTypeConfiguration<PermohonanFakturDB>
    {
        public void Configure(EntityTypeBuilder<PermohonanFakturDB> builder)
        {
            builder.ToTable("PermohonanFakturDB", "Penjualan");
            builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("PermohonanFakturDB_hilo").IsRequired();

            builder.Property(e=>e.NoRegistrasiFaktur).HasColumnName("NoRegistrasiFaktur").HasMaxLength(50);
            builder.Property(e => e.TanggalMohonFaktur).HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.PenjualanDetailId);

            builder.Property(e => e.TanggalLahir).HasColumnType("datetime");

            builder.Property(e => e.NomorKTP)
            .HasColumnName("NomorKTP")
            .HasMaxLength(30)
            .IsUnicode(false);

            builder.Property(e => e.NamaFaktur)
                .HasMaxLength(40)
                .IsUnicode(false);

            builder.Property(e => e.Alamat)
               .HasMaxLength(150)
               .IsUnicode(false);

            builder.Property(e => e.Kelurahan)
                .HasColumnName("kelF")
                .HasMaxLength(60)
                .IsUnicode(false);

            builder.Property(e => e.Kecamatan)
              .HasMaxLength(60)
              .IsUnicode(false);

            builder.Property(e => e.Kota)
               .HasMaxLength(60)
               .IsUnicode(false);
            builder.Property(e => e.Propinsi)
                .HasMaxLength(60)
                .IsUnicode(false);
            builder.Property(e => e.KodePos)
               .HasMaxLength(7)
               .IsUnicode(false);

            builder.Property(e => e.Telepon)
                .HasMaxLength(15)
                .IsUnicode(false);
            builder.Property(e => e.HandphoneF)
               .HasMaxLength(20)
               .IsUnicode(false);




        }
    }
}
