using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Persistence.Configurations
{
    public class DataPegawaiFotoConfiguration : IEntityTypeConfiguration<DataPegawaiFoto>
    {
        public void Configure(EntityTypeBuilder<DataPegawaiFoto> builder)
        {

            builder.HasKey(e => e.NoUrut);

            builder.ToTable("DataPegawaiFoto", "DataPegawai");
          

            builder.Property(e=>e.NoUrut).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;

            builder.Property(e => e.Foto).HasColumnType("image");

            builder.Property(e => e.IDPegawai).HasColumnName("IDPegawai");
            builder.Property(e => e.IDPegawai).ValueGeneratedNever();

            builder.Property(e => e.KodeBarcode)
                .HasMaxLength(25)
                .IsUnicode(false);

            builder.Property(e => e.Revisi)
                .HasColumnName("revisi")
                .HasMaxLength(1)
                .IsUnicode(false);

            builder.Property(e => e.Tglinput).HasColumnType("datetime").HasDefaultValueSql("(getdate())");


            builder.HasOne(d => d.DataPegawai)
         .WithMany(p => p.DataPegawaiFoto)
         .HasForeignKey(d => d.IDPegawai)
         .OnDelete(DeleteBehavior.ClientSetNull)
         .HasConstraintName("FK_DataPegawaiFoto_DataPegawai");

            //  throw new NotImplementedException();
        }
    }
}
