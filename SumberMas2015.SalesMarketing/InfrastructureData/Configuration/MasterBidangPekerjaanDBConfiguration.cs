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
    public class MasterBidangPekerjaanDBConfiguration : IEntityTypeConfiguration<MasterBidangPekerjaanDB>
    {
        public void Configure(EntityTypeBuilder<MasterBidangPekerjaanDB> builder)
        {
            builder.ToTable("MasterBidangPekerjaanDB");
            builder.HasKey(e=>e.MasterBidangPekerjaanDBId);
           builder.Property(e => e.MasterBidangPekerjaanDBId).ValueGeneratedOnAdd();

            builder.Property(e => e.TanggalInput).HasColumnName("TanggalInput").HasColumnType("datetime")
                .HasDefaultValueSql("getdate()");

            builder.HasData(
                MasterBidangPekerjaanDB.CreateMasterBidangPekerjaanDB("Tidak Bekerja"),
                 MasterBidangPekerjaanDB.CreateMasterBidangPekerjaanDB("Pensiunan PNS/BUMN"),
                  MasterBidangPekerjaanDB.CreateMasterBidangPekerjaanDB("Tentara Nasional Indonesia (TNI) dan Kepolisian Negara Republik Indonesia (POLRI)"),
                   MasterBidangPekerjaanDB.CreateMasterBidangPekerjaanDB("Pejabat Pembuat Peraturan Perundang-undangan dan Pejabat Tinggi Pemerintah"),
                    MasterBidangPekerjaanDB.CreateMasterBidangPekerjaanDB("Manager"),
                     MasterBidangPekerjaanDB.CreateMasterBidangPekerjaanDB("Profesional"),
                      MasterBidangPekerjaanDB.CreateMasterBidangPekerjaanDB("Pegawai Negeri Sipil"),
                       MasterBidangPekerjaanDB.CreateMasterBidangPekerjaanDB("Pegawai BUMN"),
                        MasterBidangPekerjaanDB.CreateMasterBidangPekerjaanDB("Teknisi dan Asisten Profesional"),
                        MasterBidangPekerjaanDB.CreateMasterBidangPekerjaanDB("Tenaga Tata Usaha"),
                         MasterBidangPekerjaanDB.CreateMasterBidangPekerjaanDB("Tenaga Usaha Jasa dan Tenaga Penjualan"),
                          MasterBidangPekerjaanDB.CreateMasterBidangPekerjaanDB("Pekerja Terampil, Pertanian, Kehutanan, dan Perikanan"),
                           MasterBidangPekerjaanDB.CreateMasterBidangPekerjaanDB("Pekerja Pengolahan, Kerajinan,dan YBDI"),
                            MasterBidangPekerjaanDB.CreateMasterBidangPekerjaanDB("Operator dan Perakit Mesin"),
                             MasterBidangPekerjaanDB.CreateMasterBidangPekerjaanDB("Pekerja Kasar")
                    );
        }
    }
}
