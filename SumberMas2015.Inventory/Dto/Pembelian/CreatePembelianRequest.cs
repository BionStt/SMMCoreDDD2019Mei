using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.Dto.Pembelian
{
    public class CreatePembelianRequest
    {
        public int DataSupplierId { get;  set; }
        public string JenisTransaksiPembelian { get;  set; }
        public string Keterangan { get;  set; }
        public int PurchaseOrderId { get;  set; }
        public string Tenor { get;  set; }
        public string UserNameInput { get;  set; }
    }
}
