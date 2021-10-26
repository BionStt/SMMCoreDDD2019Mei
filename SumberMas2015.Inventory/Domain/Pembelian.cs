using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.Domain
{
    public class Pembelian
    {
        public Guid PembelianId { get; private set; }

        public DateTime TanggalBeli { get; private set; }

        public Guid SupplierId { get; private set; }

        public string JnsTransaksiPembelian { get; private set; }
        public string Tenor { get; private set; }

        public string Keterangan { get; private set; }
        public string UserNameInput { get; private set; }
        public Guid PurchaseOrderPembelianId { get; private set; }
        public int NoUrutId { get; set; }
        public string Batal { get; private set; }
        // public Guid UserInputId { get; private set; }


        protected Pembelian()
        {

        }

        private Pembelian(Guid supplierId, string jnsTransaksiPembelian, string tenor, string keterangan, string userNameInput, Guid purchaseOrderPembelianId)
        {
            PembelianId = Guid.NewGuid();
            SupplierId = supplierId;
            JnsTransaksiPembelian = jnsTransaksiPembelian;
            Tenor = tenor;
            Keterangan = keterangan;
            UserNameInput = userNameInput;
            PurchaseOrderPembelianId = purchaseOrderPembelianId;
        }
        public static Pembelian CreatePembelian(Guid supplierId, string jnsTransaksiPembelian, string tenor, string keterangan, string userNameInput, Guid purchaseOrderPembelianId)
        {
            return new Pembelian(supplierId, jnsTransaksiPembelian, tenor, keterangan, userNameInput, purchaseOrderPembelianId);
        }
    }
}
