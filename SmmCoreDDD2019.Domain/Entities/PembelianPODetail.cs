using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Domain.Entities
{
    public class PembelianPODetail : BaseEntity
    {
     //   public int NoUrutPoDet { get; set; }
        public int? PembelianPOId { get; set; }
      
        public int? MasterBarangDBId { get; set; }
      
        public decimal? OffTheRoad { get; set; }
      
        public decimal? Bbn { get; set; }
        public decimal? Diskon { get; set; }
        public string Warna { get; set; }
        public int? Qty { get; set; }
        public string Keterangan { get; set; }
    }
}
