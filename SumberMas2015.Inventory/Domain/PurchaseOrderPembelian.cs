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
        public string UserName { get; set; }
        public Guid UserNameId { get; set; }
        public string PoAstra { get; set; }
        public int NoUrutId { get; set; }
        protected PurchaseOrderPembelian()
        {

        }

        private PurchaseOrderPembelian(Guid masterSupplierDBId, string keterangan, string poAstra, string userName, Guid userNameId)
        {
            PurchaseOrderPembelianId = Guid.NewGuid();
            MasterSupplierDBId = masterSupplierDBId;
            // NoRegistrasiPoPMB = noRegistrasiPoPMB; // mau dibuatin fungsi tersendir
            Keterangan = keterangan;
            // Terinput = terinput;
           
            PoAstra = poAstra;
            UserName=userName;
            UserNameId=userNameId;
        }
        public static PurchaseOrderPembelian CreatePurchaseOrderPembelian(Guid masterSupplierDBId, string keterangan, string userName, Guid userNameId, string poAstra)
        {
            return new PurchaseOrderPembelian(masterSupplierDBId, keterangan, poAstra, userName,userNameId);
        }
    }
}
