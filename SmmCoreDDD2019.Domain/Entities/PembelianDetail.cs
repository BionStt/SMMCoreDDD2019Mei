using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Domain.Entities
{
    public class PembelianDetail : BaseEntity
    {
            //  public int KodeBeliDetail { get; set; }
              public int PembelianId { get; set; }
              public int? MasterBarangDBId { get; set; }
              public decimal? HargaOffTheRoad { get; set; }
              public decimal? BBN { get; set; }
              public int Qty { get; set; }
              public decimal? Diskon { get; set; }
              public decimal? SellIn { get; set; }
              public decimal? Harga1 { get; set; }
              public decimal? Diskon2 { get; set; }
             public decimal? SellIn2 { get; set; }
             public decimal? HargaPPN { get; set; }
             public decimal? DiskonPPN { get; set; }
             public decimal? SellInPPN { get; set; }

        public StokUnit StokUnit { get; set; }
    }
}
