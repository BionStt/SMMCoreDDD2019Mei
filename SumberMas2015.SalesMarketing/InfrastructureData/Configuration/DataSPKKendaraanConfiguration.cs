using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SumberMas2015.SalesMarketing.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.InfrastructureData.Configuration
{
    public class DataSPKKendaraanConfiguration : IEntityTypeConfiguration<DataSPKKendaraan>
    {
        public void Configure(EntityTypeBuilder<DataSPKKendaraan> builder)
        {
            builder.ToTable("DataSPKKendaraan");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.TahunPerakitan).HasMaxLength(5).IsUnicode(false);
            builder.Property(e => e.Warna).HasMaxLength(25).IsUnicode(false);
            builder.Property(e => e.NamaSTNK).HasMaxLength(35).IsUnicode(false);
            builder.Property(e => e.NoKtpSTNK).HasMaxLength(25);



        }
    }
}
