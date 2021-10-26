using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.Domain
{
    public class PembelianDetail
    {
        public Guid PembelianDetailId { get; private set; }
        public Guid PembelianId { get; private set; }
        public Guid MasterBarangDBId { get; private set; }
        public decimal? HargaOffTheRoad { get; private set; }
        public decimal? BBN { get; private set; }
        public int Qty { get; private set; }
        public decimal? Diskon { get; private set; }
        public decimal? SellIn { get; private set; }
        public decimal? Harga1 { get; private set; }
        public decimal? Diskon2 { get; private set; }
        public decimal? SellIn2 { get; private set; }
        public decimal? HargaPPN { get; private set; }
        public decimal? DiskonPPN { get; private set; }
        public decimal? SellInPPN { get; private set; }
        public int NoUrutId { get; set; }
        protected PembelianDetail()
        {

        }

        private PembelianDetail(Guid masterBarangDBId, decimal? hargaOffTheRoad, decimal? bBN, int qty, decimal? diskon, decimal? sellIn, decimal? harga1, decimal? diskon2, decimal? sellIn2, decimal? hargaPPN, decimal? diskonPPN, decimal? sellInPPN, Guid pembelianId)
        {
            PembelianDetailId = Guid.NewGuid();
            MasterBarangDBId = masterBarangDBId;
            HargaOffTheRoad = hargaOffTheRoad;
            BBN = bBN;
            Qty = qty;
            Diskon = diskon;
            SellIn = sellIn;
            Harga1 = harga1;
            Diskon2 = diskon2;
            SellIn2 = sellIn2;
            HargaPPN = hargaPPN;
            DiskonPPN = diskonPPN;
            SellInPPN = sellInPPN;
            PembelianId = pembelianId;
        }

        public static PembelianDetail CreatePembelianDetail(Guid masterBarangDBId, decimal? hargaOffTheRoad, decimal? bBN, int qty, decimal? diskon, decimal? sellIn, decimal? harga1, decimal? diskon2, decimal? sellIn2, decimal? hargaPPN, decimal? diskonPPN, decimal? sellInPPN, Guid pembelianId)
        {
            return new PembelianDetail(masterBarangDBId, hargaOffTheRoad, bBN, qty, diskon, sellIn, harga1, diskon2, sellIn2, hargaPPN, diskonPPN, sellInPPN, pembelianId);
        }
    }
}
