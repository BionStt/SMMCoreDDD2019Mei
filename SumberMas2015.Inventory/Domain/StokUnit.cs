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
        private StokUnit(Guid pembelianDetailId, Guid masterBarangId, string nomorRangka, string nomorMesin, string warna, decimal? harga, decimal? diskon, decimal? sellIn)
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
            Harga1 = harga-(harga*10/100);
            Diskon2 = diskon-(diskon*10/100);
            SellIn2 = sellIn-(sellIn*10/100);
            HargaPPN = harga*10/100;
            DiskonPPN = diskon*10/100;
            SellInPPN = sellIn*10/100;
        }



        public static StokUnit CreateStokUnit(Guid pembelianDetailId, Guid masterBarangId, string nomorRangka, string nomorMesin, string warna, decimal? harga, decimal? diskon, decimal? sellIn)
        {
            return new StokUnit(pembelianDetailId, masterBarangId, nomorRangka, nomorMesin, warna, harga, diskon, sellIn);
        }

        public Guid StokUnitId { get; private set; }
        public int NoUrutId { get; set; }
        public Guid PembelianDetailId { get; private set; }
        public Guid MasterBarangId { get; private set; }
        public string NomorRangka { get; private set; }
        public string NomorMesin { get; private set; }
        public string Warna { get; private set; }
        public string Jual { get; private set; }
        public DateTime TanggalTerjual { get; set; }
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

        public void setNoRangka(string nomorRangka)
        {
            NomorRangka = nomorRangka;
        }
        public void setNoMesin(string noMesin)
        {
            NomorMesin = noMesin;
        }
        public void SetTerjual()
        {
            Jual = "1";
            TanggalTerjual = DateTime.Now;
        }


    }
}
