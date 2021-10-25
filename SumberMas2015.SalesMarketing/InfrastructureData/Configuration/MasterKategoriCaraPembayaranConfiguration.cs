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
    public class MasterKategoriCaraPembayaranConfiguration : IEntityTypeConfiguration<MasterKategoriCaraPembayaran>
    {
        public void Configure(EntityTypeBuilder<MasterKategoriCaraPembayaran> builder)
        {
            builder.ToTable("MasterKategoriCaraPembayaran");
            // builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("MasterKategoriCaraPembayaran_hilo").IsRequired();
            builder.HasKey(e => e.MasterKategoriCaraPembayaranId);
            builder.Property(e => e.NoUrutId).ValueGeneratedOnAdd();

            builder.Property(e => e.CaraPembayaran)
                .HasMaxLength(50)
                .IsUnicode(false);


        }
    }
}
