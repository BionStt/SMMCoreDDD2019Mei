using System;
using System.Collections.Generic;
using System.Text;

namespace SmmCoreDDD2019.Domain.Entities
{
   public class MasterBarangDB : BaseEntity
    {

        //public MasterBarangDb()
        //{
        //    DataSpkkendDb = new HashSet<DataSpkkendDb>();
        //    PenjualanDetailDb = new HashSet<PenjualanDetailDb>();
        //}

      //  public int NoUrutTypeKendaraan { get; set; }
        public string Aktif { get; set; }
        public decimal? BBN { get; set; }
        public string Cc { get; set; }
        public decimal? Harga { get; set; }
        public string Merek { get; set; }
        public string NamaBarang { get; set; }
        public string NomorRangka { get; set; }
        public string NomorMesin { get; set; }
        public int? Tahun { get; set; }
        public string Tipe { get; set; }
        public string TypeKendaraan { get; set; }

        public DataSPKKendaraanDB DataSPKKendaraanDB { get; set; }
        public PembelianDetail PembelianDetail { get; set; }
        public StokUnit StokUnit { get; set; }
        //public ICollection<DataSpkkendDb> DataSpkkendDb { get; set; }
        //public ICollection<PenjualanDetailDb> PenjualanDetailDb { get; set; }

    }
}
