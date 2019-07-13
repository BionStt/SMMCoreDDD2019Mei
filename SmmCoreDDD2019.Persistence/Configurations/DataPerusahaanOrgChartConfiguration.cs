using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmmCoreDDD2019.Domain.Entities;


namespace SmmCoreDDD2019.Persistence.Configurations
{
    public class DataPerusahaanOrgChartConfiguration : IEntityTypeConfiguration<DataPerusahaanOrgChart>
    {
        public void Configure(EntityTypeBuilder<DataPerusahaanOrgChart> builder)
        {
            builder.ToTable("DataPerusahaanOrgChart", "DataPerusahaan");
            builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("DataPerusahaanOrgChart_hilo").IsRequired();

            builder.Property(e => e.Lft).HasColumnName("Lft").ValueGeneratedOnAddOrUpdate();
            builder.Property(e => e.Rgt).HasColumnName("Rgt").ValueGeneratedOnAddOrUpdate();
            builder.Property(e => e.Parent).HasColumnName("Parent").HasMaxLength(15);
            builder.Property(e => e.Depth).HasColumnName("Depth").ValueGeneratedOnAddOrUpdate();
            builder.Property(e => e.KodeStrukturJabatan).HasColumnName("KodeStrukturJabatan").HasMaxLength(50);
            builder.Property(e => e.NamaStrukturJabatan).HasColumnName("NamaStrukturJabatan").HasMaxLength(200).IsUnicode(false);

        }
    }
}
