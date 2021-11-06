using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SumberMas2015.SalesMarketing.Domain;

namespace SumberMas2015.SalesMarketing.InfrastructureData.Configuration
{
    public class PermohonanFakturConfiguration : IEntityTypeConfiguration<PermohonanFaktur>
    {
        public void Configure(EntityTypeBuilder<PermohonanFaktur> builder)
        {
            builder.ToTable("PermohonanFaktur");

            builder.OwnsOne(o => o.AlamatFaktur, a => {
                a.WithOwner();
                a.Property(a => a.Jalan).IsUnicode(false).HasMaxLength(200);
                a.Property(a => a.Kelurahan).HasMaxLength(50);
                a.Property(a => a.Kecamatan).HasMaxLength(50);
                a.Property(a => a.Kota).HasMaxLength(50);
                a.Property(a => a.Propinsi).HasMaxLength(50);
                a.Property(a => a.KodePos).HasMaxLength(7);
                a.Property(a => a.NoTelepon).HasMaxLength(20);
                a.Property(a => a.NoFax).HasMaxLength(20);
                a.Property(a => a.NoHandphone).HasMaxLength(20);

            });

            //mau isi value object nya
        }
    }
}
