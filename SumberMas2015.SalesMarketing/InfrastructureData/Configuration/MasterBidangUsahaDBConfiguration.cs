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
    public class MasterBidangUsahaDBConfiguration : IEntityTypeConfiguration<MasterBidangUsahaDB>
    {
        public void Configure(EntityTypeBuilder<MasterBidangUsahaDB> builder)
        {
            builder.ToTable("MasterBidangUsahaDB");
            builder.HasKey(x => x.MasterBidangUsahaDBId);
            builder.Property(e => e.MasterBidangUsahaDBId).ValueGeneratedOnAdd();

            builder.Property(e => e.TanggalInput).HasColumnName("TanggalInput").HasColumnType("datetime")
                .HasDefaultValueSql("getdate()");

            builder.HasData(
                MasterBidangUsahaDB.CreateMasterBidangUsahaDB("TIDAK MEMPUNYAI USAHA"),
                  MasterBidangUsahaDB.CreateMasterBidangUsahaDB("PERTANIAN, KEHUTANAN DAN PERIKANAN"),
                    MasterBidangUsahaDB.CreateMasterBidangUsahaDB("PERTAMBANGAN DAN PENGGALIAN "),
                      MasterBidangUsahaDB.CreateMasterBidangUsahaDB("INDUSTRI PENGOLAHAN"),
                        MasterBidangUsahaDB.CreateMasterBidangUsahaDB("PENGADAAN LISTRIK, GAS, UAP/AIR PANAS DAN UDARA DINGIN"),
                        MasterBidangUsahaDB.CreateMasterBidangUsahaDB("PENGELOLAAN AIR, PENGELOLAAN AIR LIMBAH, PENGELOLAAN DAN DAUR ULANG SAMPAH, DAN AKTIVITAS REMEDIASI"),
                              MasterBidangUsahaDB.CreateMasterBidangUsahaDB("KONSTRUKSI"),
                                MasterBidangUsahaDB.CreateMasterBidangUsahaDB("PERDAGANGAN BESAR DAN ECERAN; REPARASI DAN PERAWATAN MOBIL DAN SEPEDA MOTOR"),
                                  MasterBidangUsahaDB.CreateMasterBidangUsahaDB( "PENGANGKUTAN DAN PERGUDANGAN"),
                                  MasterBidangUsahaDB.CreateMasterBidangUsahaDB("PENYEDIAAN AKOMODASI DAN PENYEDIAAN MAKAN MINUM"),
                                  MasterBidangUsahaDB.CreateMasterBidangUsahaDB("INFORMASI DAN KOMUNIKASI"),
                                  MasterBidangUsahaDB.CreateMasterBidangUsahaDB("AKTIVITAS KEUANGAN DAN ASURANSI"),
                            MasterBidangUsahaDB.CreateMasterBidangUsahaDB("REAL ESTAT"),
                            MasterBidangUsahaDB.CreateMasterBidangUsahaDB("AKTIVITAS PROFESIONAL, ILMIAH DAN TEKNIS"),
                            MasterBidangUsahaDB.CreateMasterBidangUsahaDB("AKTIVITAS PENYEWAAN DAN SEWA GUNA USAHA TANPA HAK OPSI, KETENAGAKERJAAN, AGEN PERJALANAN DAN PENUNJANG USAHA LAINNYA"),
                            MasterBidangUsahaDB.CreateMasterBidangUsahaDB("ADMINISTRASI PEMERINTAHAN, PERTAHANAN DAN JAMINAN SOSIAL WAJIB"),
                      MasterBidangUsahaDB.CreateMasterBidangUsahaDB("PENDIDIKAN"),
                      MasterBidangUsahaDB.CreateMasterBidangUsahaDB("AKTIVITAS KESEHATAN MANUSIA DAN AKTIVITAS SOSIAL"),
                            MasterBidangUsahaDB.CreateMasterBidangUsahaDB("KESENIAN, HIBURAN DAN REKREASI"),
                      MasterBidangUsahaDB.CreateMasterBidangUsahaDB("AKTIVITAS BADAN INTERNASIONAL DAN BADAN EKSTRA INTERNASIONAL LAINNYA"),
                      MasterBidangUsahaDB.CreateMasterBidangUsahaDB("AKTIVITAS JASA LAINNYA")
                );
        }
    }
}
