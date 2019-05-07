using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmmCoreDDD2019.Domain.Entities;



namespace SmmCoreDDD2019.Persistence.Configurations
{
    public class DataPegawaiDataPribadiConfiguration : IEntityTypeConfiguration<DataPegawaiDataPribadi>
    {
        public void Configure(EntityTypeBuilder<DataPegawaiDataPribadi> builder)
        {
            builder.HasKey(e => e.NoUrut);
            builder.ToTable("DataPegawaiDataPribadi", "DataPegawai");
         

            builder.Property(e=>e.NoUrut).UseSqlServerIdentityColumn().Metadata.BeforeSaveBehavior = Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore;

            builder.Property(e => e.IDPegawai).HasColumnName("IDPegawai");
            builder.Property(e => e.IDPegawai).ValueGeneratedNever();

            builder.Property(e => e.NamaDepan)
           .HasMaxLength(75)
             .IsUnicode(false);

   
              builder.Property(e => e.NamaTengah)
              .HasMaxLength(75)
              .IsUnicode(false);

               builder.Property(e => e.NamaBelakang)
                .HasMaxLength(75)
                .IsUnicode(false);


            builder.Property(e => e.AlamatRumah)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.KelurahanRumah)
           .HasMaxLength(40)
           .IsUnicode(false);

            builder.Property(e => e.KecamatanRumah)
               .HasMaxLength(40)
               .IsUnicode(false);

            builder.Property(e => e.KotaRumah)
             .HasMaxLength(50)
             .IsUnicode(false);
            builder.Property(e => e.PropinsiRumah)
            .HasMaxLength(50)
            .IsUnicode(false);

            builder.Property(e => e.KodePos)
             .HasColumnName("KodePos")
           .HasMaxLength(10)
             .IsUnicode(false);

            builder.Property(e => e.AlamatKTP)
        .HasColumnName("AlamatKTP")
        .HasMaxLength(300)
        .IsUnicode(false);

            builder.Property(e => e.KelurahanKTP)
       .HasColumnName("KelurahanKTP")
       .HasMaxLength(50)
       .IsUnicode(false);

            builder.Property(e => e.KecamatanKTP)
                .HasColumnName("KecamatanKTP")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.KotaKTP)
        .HasColumnName("KotaKTP")
        .HasMaxLength(50)
        .IsUnicode(false);
            builder.Property(e => e.PropinsiKTP)
      .HasColumnName("PropinsiKTP")
      .HasMaxLength(50)
      .IsUnicode(false);

            builder.Property(e => e.KodePosKTP)
                .HasColumnName("KodePosKTP")
                .HasMaxLength(10)
                .IsUnicode(false);

            builder.Property(e => e.NoKTP)
                .HasColumnName("NoKTP")
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.Telp)
        .HasMaxLength(20)
        .IsUnicode(false);

            builder.Property(e => e.Handphone)
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.Handphone2)
                .HasColumnName("Handphone2")
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(e => e.Agama)
                .HasMaxLength(1)
                .IsUnicode(false);



            builder.Property(e => e.TempatLahir)
               .HasMaxLength(30)
               .IsUnicode(false);

            builder.Property(e => e.TanggalLahir).HasColumnType("datetime");


            builder.Property(e => e.JenisKelamin)
                .HasMaxLength(1)
                .IsUnicode(false);

            builder.Property(e => e.StatusKawin)
       .HasMaxLength(1)
       .IsUnicode(false);

            builder.Property(e => e.GolonganDarah)
            .HasMaxLength(4)
            .IsUnicode(false);

            builder.Property(e => e.StatusTempatTinggal)
                .HasMaxLength(1)
                .IsUnicode(false);



            builder.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);

        
        
            builder.Property(e => e.TglInput).HasColumnType("datetime").HasDefaultValueSql("(getdate())");

           

            builder.HasOne(d => d.DataPegawai)
                   .WithOne(p => p.DataPegawaiDataPribadi)
                   .HasForeignKey<DataPegawaiDataPribadi>(d => d.IDPegawai)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_DataPegawaiDataPribadi_DataPegawai");
             
            
        }
    }
}
