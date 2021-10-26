using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.Dto.PembelianDetail
{
    public class GetListPembelianDetailResponse
    {
        public int NoUrutPembelianDetail { get; set; }
        public string NamaBarang1 { get; set; }
        public string HargaOff { get; set; }
        public string BBN1 { get; set; }
        public string HargaOTr { get; set; }
        public string Diskon { get; set; }
        public string SellIn { get; set; }
        public int Qty1 { get; set; }
        public string Count1 { get; set; }
    }
}
