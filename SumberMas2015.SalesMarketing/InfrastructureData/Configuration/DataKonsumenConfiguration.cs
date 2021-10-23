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
    public class DataKonsumenConfiguration : IEntityTypeConfiguration<DataKonsumen>
    {
        public void Configure(EntityTypeBuilder<DataKonsumen> builder)
        {
            builder.ToTable("DataKonsumen");
            builder.HasKey(b => b.Id);

            //builder.OwnsOne(o => o.NoKTP, a => {
            //    a.WithOwner();
            //    a.Property(a => a.Value).HasColumnName("NoKTP").IsRequired();
            //});

            builder.Property(e => e.TanggalLahir).HasColumnType("datetime");

            //var converterJenisKelamin = new EnumToStringConverter<JenisKelamin>();
            //builder.Property(e => e.JenisKelamin).HasConversion(converterJenisKelamin);

            //var converterAgama = new EnumToStringConverter<Agama>();
            //builder.Property(e => e.Agama).HasConversion(converterAgama);

            //type variable value object DDD
            builder.OwnsOne(o => o.Nama, a => {
                a.WithOwner();
                a.Property(a => a.NamaDepan).IsUnicode(false).IsRequired();
                a.Property(a => a.NamaBelakang).IsUnicode(false).IsRequired();
            });

            builder.OwnsOne(o => o.NamaBPKB, a => {
                a.WithOwner();
                a.Property(a => a.NamaDepan).IsUnicode(false).IsRequired();
                a.Property(a => a.NamaBelakang).IsUnicode(false).IsRequired();
            });

            builder.OwnsOne(o => o.AlamatTinggal, a => {
                a.WithOwner();
                a.Property(a => a.Jalan).IsUnicode(false).HasMaxLength(200);
                a.Property(a => a.Kelurahan).HasMaxLength(50);
                a.Property(a => a.Kecamatan).HasMaxLength(50);
                a.Property(a => a.Kota).HasMaxLength(50);
                a.Property(a => a.Propinsi).HasMaxLength(50);
                a.Property(a => a.KodePos).HasMaxLength(7);
                a.Property(a => a.NoTelepon).HasMaxLength(20);
                a.Property(a => a.NoFax).HasMaxLength(20);
                a.Property(a => a.NoHandphone).HasMaxLength(20);

            });

            builder.OwnsOne(o => o.AlamatKirim, a => {
                a.WithOwner();
                a.Property(a => a.Jalan).IsUnicode(false).HasMaxLength(200);
                a.Property(a => a.Kelurahan).HasMaxLength(50);
                a.Property(a => a.Kecamatan).HasMaxLength(50);
                a.Property(a => a.Kota).HasMaxLength(50);
                a.Property(a => a.Propinsi).HasMaxLength(50);
                a.Property(a => a.KodePos).HasMaxLength(7);
                a.Property(a => a.NoTelepon).HasMaxLength(20);
                a.Property(a => a.NoFax).HasMaxLength(20);
                a.Property(a => a.NoHandphone).HasMaxLength(20);
            });

            builder.Property(e => e.Email).HasMaxLength(40);
            builder.Property(e => e.CreatedAt).HasDefaultValueSql("GetUtcDate()");// if not using sql please check again



        }
    }
}
