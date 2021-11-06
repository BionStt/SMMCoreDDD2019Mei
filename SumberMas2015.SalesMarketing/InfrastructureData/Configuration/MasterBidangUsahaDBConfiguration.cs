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
    public class MasterBidangUsahaDBConfiguration : IEntityTypeConfiguration<MasterBidangUsahaDB>
    {
        public void Configure(EntityTypeBuilder<MasterBidangUsahaDB> builder)
        {
            builder.ToTable("MasterBidangUsahaDB");

            builder.HasKey(x => x.MasterBidangUsahaGuid);
            builder.Property(e => e.NoUrutId).ValueGeneratedOnAdd();



            //builder.HasData(
            //   
            //    );

            builder.Property(e => e.TanggalInput).HasColumnName("TanggalInput").HasColumnType("datetime")
              .HasDefaultValueSql("getdate()");
        }
    }
}
