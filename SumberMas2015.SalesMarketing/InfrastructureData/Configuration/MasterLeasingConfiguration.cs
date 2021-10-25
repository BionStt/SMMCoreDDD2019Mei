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
    public class MasterLeasingConfiguration : IEntityTypeConfiguration<MasterLeasing>
    {
        public void Configure(EntityTypeBuilder<MasterLeasing> builder)
        {
            builder.ToTable("MasterLeasing");
            builder.HasKey(e => e.MasterLeasingId);

            builder.Property(e => e.NoUrutId).ValueGeneratedOnAdd();

            builder.Property(e => e.NamaLeasing).HasMaxLength(50)
                .IsUnicode(false);

        }
    }
}
