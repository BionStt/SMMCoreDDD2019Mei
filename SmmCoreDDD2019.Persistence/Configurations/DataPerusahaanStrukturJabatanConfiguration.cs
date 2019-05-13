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
    public class DataPerusahaanStrukturJabatanConfiguration : IEntityTypeConfiguration<DataPerusahaanStrukturJabatan>
    {
        public void Configure(EntityTypeBuilder<DataPerusahaanStrukturJabatan> builder)
        {
            builder.ToTable("DataPerusahaanStrukturJabatan", "DataPerusahaan");
      
            builder.HasKey(e => e.NoUrutStrukturID);
            builder.Property(e => e.NoUrutStrukturID).HasColumnName("NoUrutStrukturID");
            builder.Property(e => e.NoUrutStrukturID).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;

            builder.Property(e => e.Lft).HasColumnName("Lft").ValueGeneratedOnAddOrUpdate();
            builder.Property(e => e.Rgt).HasColumnName("Rgt").ValueGeneratedOnAddOrUpdate();
            builder.Property(e => e.Parent).HasColumnName("Parent").HasMaxLength(15);
            builder.Property(e => e.Depth).HasColumnName("Depth").ValueGeneratedOnAddOrUpdate();
                      
            builder.Property(e => e.KodeStruktur).HasColumnName("KodeStruktur").HasMaxLength(50);
            builder.Property(e => e.NamaStrukturJabatan).HasColumnName("NamaStrukturJabatan").HasMaxLength(200).IsUnicode(false);
        
        
           
        }
    }
}
