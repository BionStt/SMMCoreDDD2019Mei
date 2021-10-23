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
    public class MasterKategoriBayaranConfiguration : IEntityTypeConfiguration<MasterKategoriBayaran>
    {
        public void Configure(EntityTypeBuilder<MasterKategoriBayaran> builder)
        {
            builder.ToTable("MasterKategoriBayaran");
          //  builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("MasterKategoriBayaran_hilo").IsRequired();

            builder.Property(e => e.NamaKategoryBayaran)
                .HasMaxLength(30)
                .IsUnicode(false);

        }
    }
}
