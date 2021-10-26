using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.Domain
{
    public class StokUnit
    {
        protected StokUnit()
        {

        }
        private StokUnit(Guid pembelianDetailId, Guid masterBarangId, string nomorRangka, string nomorMesin, string warna, decimal? harga, decimal? diskon, decimal? sellIn, decimal? harga1, decimal? diskon2, decimal? sellIn2, decimal? hargaPPN, decimal? diskonPPN, decimal? sellInPPN)
        {
            StokUnitId = Guid.NewGuid();
            PembelianDetailId = pembelianDetailId;
            MasterBarangId = masterBarangId;
            NomorRangka = nomorRangka;
            NomorMesin = nomorMesin;
            Warna = warna;
            //  Jual = jual;
            //Kembali = kembali;
            // Faktur = faktur;
            Harga = harga;
            Diskon = diskon;
            SellIn = sellIn;
            Harga1 = harga1;
            Diskon2 = diskon2;
            SellIn2 = sellIn2;
            HargaPPN = hargaPPN;
            DiskonPPN = diskonPPN;
            SellInPPN = sellInPPN;
        }
        public static StokUnit CreateStokUnit(Guid pembelianDetailId, Guid masterBarangId, string nomorRangka, string nomorMesin, string warna, decimal? harga, decimal? diskon, decimal? sellIn, decimal? harga1, decimal? diskon2, decimal? sellIn2, decimal? hargaPPN, decimal? diskonPPN, decimal? sellInPPN)
        {
            return new StokUnit(pembelianDetailId, masterBarangId, nomorRangka, nomorMesin, warna, harga, diskon, sellIn, harga1, diskon2, sellIn2, hargaPPN, diskonPPN, sellInPPN);
        }

        public Guid StokUnitId { get; private set; }
        public int NoUrutId { get; set; }
        public Guid PembelianDetailId { get; private set; }
        public Guid MasterBarangId { get; private set; }
        public string NomorRangka { get; private set; }
        public string NomorMesin { get; private set; }
        public string Warna { get; private set; }
        public string Jual { get; private set; }
        public string Kembali { get; private set; }
        public string Faktur { get; private set; }
        public decimal? Harga { get; private set; }
        public decimal? Diskon { get; private set; }
        public decimal? SellIn { get; private set; }
        public decimal? Harga1 { get; private set; }
        public decimal? Diskon2 { get; private set; }
        public decimal? SellIn2 { get; private set; }
        public decimal? HargaPPN { get; private set; }
        public decimal? DiskonPPN { get; private set; }
        public decimal? SellInPPN { get; private set; }

        public DateTime TanggalInput { get; private set; }
    }
}
