using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.Dto.PurchaseOrderPembelian
{
    public class CreatePurchaseOrderPembelianRequest
    {
        public DateTime TanggalInputPOPembelian { get; set; }
        public string Keterangan { get;  set; }
        public int MasterSupplierId { get;  set; }
        public string PoASTRA { get;  set; }
        public string UserName{ get;  set; }
        public Guid UserNameId { get; set; }
    }
}
