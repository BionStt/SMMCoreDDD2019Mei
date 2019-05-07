using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Persistence.Configurations
{
    public class CustomerDBConfiguration : IEntityTypeConfiguration<CustomerDB>
    {
        public void Configure(EntityTypeBuilder<CustomerDB> builder)
        {
            //  builder.Entity<BukuTamu>(entity => entity.ToTable("BukuTamu", "Operation"));
            // base.OnModelCreating(modelBuilder);
            // new StudentMap(modelBuilder.Entity<Student>());
            // entityBuilder.HasOne(t => t.UserProfile).WithOne(u => u.User).HasForeignKey<UserProfile>(x => x.Id);
            builder.HasKey(e => e.CustomerID);

            builder.ToTable("CustomerDB");

            builder.Property(e => e.CustomerID).HasColumnName("CustomerID");

            builder.Property(e => e.CustomerID).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;

            builder.Property(e=>e.NoKodeCustomer).HasColumnName("NoKodeCustomer").IsUnicode(false);
            builder.Property(e => e.Alamat)
              .HasMaxLength(200)
              .IsUnicode(false);

            builder.Property(e => e.AlamatKirim)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.Faks)
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.Handphone).HasMaxLength(20);

            builder.Property(e => e.Jual)
                .HasMaxLength(1)
                .IsUnicode(false);

            builder.Property(e => e.Kecamatan)
                .HasMaxLength(40)
                .IsUnicode(false);

            builder.Property(e => e.Kelurahan)
                .HasMaxLength(40)
                .IsUnicode(false);

            builder.Property(e => e.KodePos)
                .HasMaxLength(6)
                .IsUnicode(false);

            builder.Property(e => e.Kota)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Nama)
                .HasMaxLength(50)
                .IsUnicode(false);
            builder.Property(e => e.Propinsi)
             .HasMaxLength(50)
             .IsUnicode(false);

            builder.Property(e => e.NamaBPKB)
                .HasColumnName("NamaBPKB")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.NoKtp)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e=>e.Email).HasColumnName("Email").HasMaxLength(50);

            builder.Property(e => e.Telp).HasMaxLength(20);

            builder.Property(e => e.TelpKantor).HasMaxLength(20);

            //otomatis input tgl 
            builder.Property(e => e.TglInput).HasColumnType("datetime").HasDefaultValueSql("(getdate())"); 

            builder.Property(e => e.TglLahir).HasColumnType("datetime");

            builder.Property(e => e.UserIDPeg).HasColumnName("UserIDPeg");

            builder.Property(e => e.UserInput)
                .HasMaxLength(30)
                .IsUnicode(false);
            builder.Property(e => e.KodeBidangPekerjaan).HasMaxLength(1).IsUnicode(false);
            builder.Property(e => e.NamaBidangPekerjaan).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.KodeBidangUsaha).HasMaxLength(1).IsUnicode(false);
            builder.Property(e => e.NamaBidangUsaha).HasMaxLength(50).IsUnicode(false);
            //   throw new NotImplementedException();
        }
    }
}
