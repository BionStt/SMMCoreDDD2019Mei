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
    public class PermohonanSTNKConfiguration : IEntityTypeConfiguration<PermohonanSTNK>
    {
        public void Configure(EntityTypeBuilder<PermohonanSTNK> builder)
        {
            builder.ToTable("PermohonanSTNK");
            builder.Property(x => x.BbnPabrik).HasColumnType("money");
            builder.Property(x => x.BiayaTambahan).HasColumnType("money");
            builder.Property(x => x.Birojasa).HasColumnType("money");
            builder.Property(x => x.FormA).HasColumnType("money");
            builder.Property(x => x.PajakProgresif).HasColumnType("money");
            builder.Property(x => x.PajakStnk).HasColumnType("money");
            builder.Property(x => x.Perwil).HasColumnType("money");


        }
    }
}
