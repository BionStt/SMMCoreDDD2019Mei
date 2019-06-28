using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Domain.Entities
{
    public class StokUnit : BaseEntity
    {
       // public int NoUrutSo { get; set; }
      public int? PembelianDetailId { get; set; }
       public int? MasterBarangDBId{ get; set; }
      public string NoRangka { get; set; }
     public string NoMesin { get; set; }
        public string Warna { get; set; }
        public string Jual { get; set; }
        public string Kembali { get; set; }
        public string Faktur { get; set; }
     public decimal? Harga { get; set; }
      public decimal? Diskon { get; set; }
      public decimal? SellIn { get; set; }
        public decimal? Harga1 { get; set; }
        public decimal? Diskon2 { get; set; }
        public decimal? SellIn2 { get; set; }
        public decimal? HargaPPN { get; set; }
        public decimal? DiskonPPN { get; set; }
        public decimal? SellInPPN { get; set; }
     
      public DateTime? TglInput { get; set; }

        public PenjualanDetail PenjualanDetail { get; set; }
    }
}
