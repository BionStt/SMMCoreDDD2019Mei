using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SumberMas2015.Organization.Domain;

namespace SumberMas2015.Organization.InfrastructureData.Configuration
{
    public class DataPerusahaanCabangConfiguration : IEntityTypeConfiguration<DataPerusahaanCabang>
    {
        public void Configure(EntityTypeBuilder<DataPerusahaanCabang> builder)
        {
            builder.ToTable("DataPerusahaanCabang");
            builder.HasKey(e => e.NoUrutId);
            builder.Property(e => e.NoUrutId).ValueGeneratedOnAdd();

            builder.OwnsOne(o => o.AlamatPerusahaanCabang, a => {
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
        }
    }
}
