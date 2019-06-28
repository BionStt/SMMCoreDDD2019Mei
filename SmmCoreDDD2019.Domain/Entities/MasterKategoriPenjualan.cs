using System;
using System.Collections.Generic;
using System.Text;

namespace SmmCoreDDD2019.Domain.Entities
{
   public class MasterKategoriPenjualan : BaseEntity
    {
        //public MasterKategoryPenjualan()
        //{
        //    DataSpkleasingDb = new HashSet<DataSpkleasingDb>();
        //    PenjualanDb = new HashSet<PenjualanDb>();
        //}

       // public int NoUrutKategoriPenjualan { get; set; }
        public string NamaKategoryPenjualan { get; set; }

      
        public DataSPKLeasingDB DataSPKLeasingDB { get; set; }
        public Penjualan Penjualan { get; set; }
    }
}
