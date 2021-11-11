using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.Dto.PurchaseOrderPembelianDetail
{
    public class CreatePurchaseOrderPembelianDetailRequest
    {
        public int NoUrutPurchaseOrderID { get; set; }
        public int NoUrutMasterBarang { get; set; }
        public decimal? BBN { get;  set; }
        public decimal? Diskon { get;  set; }
        public string Keterangan { get;  set; }
        public decimal? OffTHeRoad { get;  set; }
        public int? Qty { get;  set; }
        public string Warna { get;  set; }
        public string UserName { get; set; }
        public Guid UserNameId { get; set; }
    }
}
