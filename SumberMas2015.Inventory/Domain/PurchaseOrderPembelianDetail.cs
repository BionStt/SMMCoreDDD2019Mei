using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.Domain
{
    public class PurchaseOrderPembelianDetail
    {
        protected PurchaseOrderPembelianDetail()
        {
            
        }
        private PurchaseOrderPembelianDetail(Guid masterBarangDBId, decimal? offTheRoad, decimal? bbn, decimal? diskon, string warna, int? qty, string keterangan, Guid purchaseOrderPembelianId)
        {
            PurchaseOrderPembelianDetailId = Guid.NewGuid();
            MasterBarangDBId = masterBarangDBId;
            OffTheRoad = offTheRoad;
            Bbn = bbn;
            Diskon = diskon;
            Warna = warna;
            Qty = qty;
            Keterangan = keterangan;
            PurchaseOrderPembelianId=purchaseOrderPembelianId;
        }
        public static PurchaseOrderPembelianDetail CreatePurchaseOrderPembelianDetail(Guid masterBarangDBId, decimal? offTheRoad, decimal? bbn, decimal? diskon, string warna, int? qty, string keterangan, Guid purchaseOrderPembelianId)
        {
            return new PurchaseOrderPembelianDetail(masterBarangDBId, offTheRoad, bbn, diskon, warna, qty, keterangan, purchaseOrderPembelianId);
        }
        public Guid PurchaseOrderPembelianId { get; set; }
        public Guid PurchaseOrderPembelianDetailId { get; private set; }

        public Guid MasterBarangDBId { get; private set; }

        public decimal? OffTheRoad { get; private set; }

        public decimal? Bbn { get; private set; }
        public decimal? Diskon { get; private set; }
        public string Warna { get; private set; }
        public int? Qty { get; private set; }
        public string Keterangan { get; private set; }
        public int NoUrutId { get; set; }

    }
}
