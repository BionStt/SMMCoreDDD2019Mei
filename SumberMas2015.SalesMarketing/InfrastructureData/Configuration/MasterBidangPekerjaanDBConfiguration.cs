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
    public class MasterBidangPekerjaanDBConfiguration : IEntityTypeConfiguration<MasterBidangPekerjaanDB>
    {
        public void Configure(EntityTypeBuilder<MasterBidangPekerjaanDB> builder)
        {
            builder.ToTable("MasterBidangPekerjaanDB");
            builder.HasKey(e=>e.NoUrutId);
           builder.Property(e => e.NoUrutId).ValueGeneratedOnAdd();
           
            builder.Property(e => e.TanggalInput).HasColumnName("TanggalInput").HasColumnType("datetime")
               .HasDefaultValueSql("getdate()");
        }
    }
}
