using System;
using System.Collections.Generic;
using System.Text;


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Persistence.Configurations
{
    public class MasterSupplierDBConfiguration : IEntityTypeConfiguration<MasterSupplierDB>
    {
        public void Configure(EntityTypeBuilder<MasterSupplierDB> builder)
        {
            builder.ToTable("MasterSupplierDB");
            builder.Property(e => e.Id).ForSqlServerUseSequenceHiLo("MasterSupplierDB_hilo").IsRequired();
        
            builder.Property(e=>e.NoRegistrasiSupplier).HasColumnName("NoRegistrasiSupplier").HasMaxLength(50);

            builder.Property(e => e.Aktif).HasMaxLength(2);

            builder.Property(e => e.Alamat).HasMaxLength(100);
            builder.Property(e => e.Kelurahan).HasMaxLength(50);
            builder.Property(e => e.Kecamatan).HasMaxLength(50);
            builder.Property(e => e.Kota).HasMaxLength(50);
            builder.Property(e => e.Propinsi).HasMaxLength(50);
            builder.Property(e => e.KodePos).HasMaxLength(10);
            builder.Property(e => e.Telp).HasMaxLength(20);
            builder.Property(e => e.Faks).HasMaxLength(20);
            builder.Property(e => e.Email).HasMaxLength(30);

            builder.Property(e => e.NamaSupplier)
                .HasColumnName("NamaSupplier")
                .HasMaxLength(30)
                .IsRequired()
                .IsUnicode(false);

        }
    }
}
