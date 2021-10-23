using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Persistence.Configurations
{
    public class MasterKategoriBayaranConfiguration : IEntityTypeConfiguration<MasterKategoriBayaran>
    {
        public void Configure(EntityTypeBuilder<MasterKategoriBayaran> builder)
        {
            builder.ToTable("MasterKategoriBayaran");
            // builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("MasterKategoriBayaran_hilo").IsRequired();
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.NamaKategoryBayaran)
                .HasMaxLength(30)
                .IsUnicode(false);


        }
    }
}
