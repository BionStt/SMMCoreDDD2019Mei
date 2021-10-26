using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.Dto.StokUnit
{
    public class CreateStokUnitRequest
    {
        public int masterBarangId { get; set; }
        public int pembelianDetailId { get; set; }

        public decimal? Diskon { get;  set; }
        public decimal? Diskon2 { get;  set; }
        public decimal? DiskonPPN { get;  set; }
        public decimal? Harga { get;  set; }
        public decimal? Harga1 { get;  set; }
        public decimal? HargaPPN { get;  set; }
        public string NomorMesin { get;  set; }
        public string NomorRangka { get;  set; }
        public decimal? Sellin { get;  set; }
        public decimal? SellIn2 { get;  set; }
        public decimal? SellInPPN { get;  set; }
        public string Warna { get;  set; }
    }
}
