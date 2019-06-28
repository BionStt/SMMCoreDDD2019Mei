using System;
using System.Collections.Generic;
using System.Text;

namespace SmmCoreDDD2019.Domain.Entities
{
    public class MasterSupplierDB : BaseEntity
    {

        //public SupplierDb()
        //{
        //    PenjualanDetailDb = new HashSet<PenjualanDetailDb>();
        //}

        //   public int IDSupplier { get; set; }
        public string NoRegistrasiSupplier { get; set; }
        public string Aktif { get; set; }
        public string Alamat { get; set; }
        public string Kelurahan { get; set; }
        public string Kecamatan { get; set; }
        public string Kota { get; set; }
        public string Propinsi { get; set; }
        public string KodePos { get; set; }
        public string NamaSupplier { get; set; }
        public string Telp { get; set; }
        public string Faks { get; set; }
        public string Email { get; set; }

        public PembelianPO PembelianPO { get; set; }

        public Pembelian Pembelian { get; set; }

        //  public ICollection<PenjualanDetailDb> PenjualanDetailDb { get; set; }
    }
}
