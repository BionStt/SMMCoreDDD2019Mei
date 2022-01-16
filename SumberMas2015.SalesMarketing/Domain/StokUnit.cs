using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Domain
{
    public class StokUnit
    {
        private StokUnit(Guid stokUnitId, Guid masterBarangId, string nomorRangka, string nomorMesin, string namaSupplier, string warna)
        {
            StokUnitId=stokUnitId;

            MasterBarangId=masterBarangId;
            NomorRangka=nomorRangka;
            NomorMesin=nomorMesin;
            NamaSupplier=namaSupplier;
            TanggalInput=DateTime.Now;
            Warna=warna;
        }
        public static StokUnit CreateStokUnit(Guid stokUnitId,  Guid masterBarangId, string nomorRangka, string nomorMesin, string namaSupplier, string warna)
        {
            return new StokUnit(stokUnitId,masterBarangId,nomorRangka,nomorMesin,namaSupplier,warna);
        }
        protected StokUnit()
        {

        }
        public Guid StokUnitId { get; private set; }
        public int NoUrutId { get; set; }
        public Guid MasterBarangId { get; private set; }
        public string NomorRangka { get; private set; }
        public string NomorMesin { get; private set; }
        public string Warna { get;private set; }
        public string NamaSupplier { get; private set; }
        public DateTime TanggalInput { get; private set; }
        public DateTime TanggalTerjual{ get; set; }
        public string Terjual { get; set; } = "0";
        public void SetTerjual()
        {
            Terjual = "1";
            TanggalTerjual = DateTime.Now.Date;
        }

    }
}
