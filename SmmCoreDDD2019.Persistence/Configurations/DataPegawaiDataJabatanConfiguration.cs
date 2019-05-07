using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Persistence.Configurations
{
    public class DataPegawaiDataJabatanConfiguration : IEntityTypeConfiguration<DataPegawaiDataJabatan>
    {
        public void Configure(EntityTypeBuilder<DataPegawaiDataJabatan> builder)
        {

            builder.HasKey(e => e.NoUrut);

            builder.ToTable("DataPegawaiDataJabatan", "DataPegawai");
            builder.Property(e=>e.NoUrut).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;

            // builder.Property(e => e.NoUrut).UseSqlServerIdentityColumn();
            //modelBuilder.Entity<Foo>().Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            builder.Property(e => e.IDPegawai).ValueGeneratedNever();

            builder.Property(e => e.NoUrutJabatan).HasColumnName("NoUrutJabatan");

            builder.Property(e => e.Keterangan)
                .HasMaxLength(400)
                .IsUnicode(false);

            builder.Property(e => e.TglBerhentiMenjabat).HasColumnType("datetime");

            builder.Property(e => e.TglMenjabat).HasColumnType("datetime").HasDefaultValueSql("(getdate())");

            builder.HasOne(d => d.MasterJenisJabatan)
                .WithMany(p => p.DataPegawaiDataJabatan)
                .HasForeignKey(d => d.NoUrutJabatan)
                .HasConstraintName("FK_DataPegawaiDataJabatan_MasterJenisJabatan");
            //  throw new NotImplementedException();
        }
    }
}
