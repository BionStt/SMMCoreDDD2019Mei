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
    public class PenjualanPiutangConfiguration : IEntityTypeConfiguration<PenjualanPiutang>
    {
        public void Configure(EntityTypeBuilder<PenjualanPiutang> builder)
        {
            builder.HasKey(e => e.NoUrutPjPiutang);
            builder.ToTable("PenjualanPiutang","Penjualan");
            builder.Property(e => e.NoUrutPjPiutang).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;

            builder.Property(e=>e.TanggalLunas).HasColumnType("datetime");
            builder.Property(e=>e.KodePenjualanDetail).HasColumnName("KodePenjualanDetail").IsUnicode(false);

            builder.Property(e => e.Keterangan).HasColumnName("Keterangan").IsUnicode(false);


        }
    }
}
