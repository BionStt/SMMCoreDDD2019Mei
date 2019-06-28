using System;
using System.Collections.Generic;
using System.Text;

namespace SmmCoreDDD2019.Domain.Entities
{
   public class DataSPKLeasingDB : BaseEntity
    {
       // public int NoUrut { get; set; }
        public decimal? Angsuran { get; set; }
        public int? MasterLeasingCabangDBId { get; set; }
        public string Mediator { get; set; }
        public string NamaCmo { get; set; }
        public int? MasterKategoriBayaranId { get; set; }
        public int? MasterKategoriPenjualanId { get; set; }
      //  public int? NoUrutMarco { get; set; }
        public int? NoUrutSales { get; set; }
        public int? DataSPKBaruDBId { get; set; }
        public int? Tenor { get; set; }
        public DateTime? TglSurvei { get; set; }

      
        public MasterKategoriBayaran MasterKategoriBayaran { get; set; }
        public MasterKategoriPenjualan MasterKategoriPenjualan { get; set; }
       public MasterLeasingCabangDB MasterLeasingCabangDB { get; set; }
     
    }
}
