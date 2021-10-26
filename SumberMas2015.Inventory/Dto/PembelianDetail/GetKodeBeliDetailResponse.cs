using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.Dto.PembelianDetail
{
    public class GetKodeBeliDetailResponse
    {
        public int NoKodeBeli1 { get; set; }
        public int NoKodeBeliDetail { get; set; }
        public int KodeBarang { get; set; }
        public string NamaBarang1 { get; set; }
        public decimal? HargaOff { get; set; }

        public decimal? Diskon1 { get; set; }
        public decimal? SellIn1 { get; set; }

    }
}
