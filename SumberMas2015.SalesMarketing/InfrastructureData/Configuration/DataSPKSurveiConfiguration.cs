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
    public class DataSPKSurveiConfiguration : IEntityTypeConfiguration<DataSPKSurvei>
    {
        public void Configure(EntityTypeBuilder<DataSPKSurvei> builder)
        {
            builder.ToTable("DataSPKSurvei");
            builder.HasKey(e => e.DataSPKSurveiId);
            builder.Property(e => e.NoUrutId).ValueGeneratedOnAdd();

            builder.Property(e => e.NoKTPPemesan).IsUnicode(false);
            //builder.Property(e => e.NamaPemesan).HasMaxLength(35).IsUnicode(false);

            builder.OwnsOne(o => o.NamaPemesan, a => {
                a.WithOwner();
                a.Property(a => a.NamaDepan).HasMaxLength(40);
                a.Property(a => a.NamaBelakang).HasMaxLength(40);
            });

            builder.OwnsOne(o => o.AlamatPemesan, a => {
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

            builder.OwnsOne(o => o.DataNPWPPemesan, a => {
                a.WithOwner();
                a.Property(a => a.NoNPWP).HasMaxLength(25);
                a.Property(a => a.NamaNPWP).HasMaxLength(50);
                a.OwnsOne(i => i.AlamatNPWP, a => {
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
            });
            builder.Property(e => e.PekerjaanPemesan).HasMaxLength(50).IsUnicode(false);




        }
    }
}
