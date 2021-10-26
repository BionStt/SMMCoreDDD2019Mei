using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.Domain
{
    public class PurchaseOrderPembelian
    {
        public Guid PurchaseOrderPembelianId { get; set; }

        public DateTime TanggalPurchaseOrder { get; set; }
        public Guid MasterSupplierDBId { get; set; }
        public string NoRegistrasiPoPMB { get; set; }
        public string Keterangan { get; set; }
        public string Terinput { get; set; }
        // public int? UserId { get; set; }
        public string UserInput { get; set; }
        public string PoAstra { get; set; }
        public int NoUrutId { get; set; }
        protected PurchaseOrderPembelian()
        {

        }

        private PurchaseOrderPembelian(Guid masterSupplierDBId, string keterangan, string userInput, string poAstra)
        {
            PurchaseOrderPembelianId = Guid.NewGuid();
            MasterSupplierDBId = masterSupplierDBId;
            // NoRegistrasiPoPMB = noRegistrasiPoPMB; // mau dibuatin fungsi tersendir
            Keterangan = keterangan;
            // Terinput = terinput;
            UserInput = userInput;
            PoAstra = poAstra;
        }
        public static PurchaseOrderPembelian CreatePurchaseOrderPembelian(Guid masterSupplierDBId, string keterangan, string userInput, string poAstra)
        {
            return new PurchaseOrderPembelian(masterSupplierDBId, keterangan, userInput, poAstra);
        }
    }
}
