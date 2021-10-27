using SumberMas2015.Organization.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Organization.Domain
{
    public class DataPerusahaanCabang
    {
        public static DataPerusahaanCabang CreateDataPerusahaanCabang(Guid dataPerusahaanId, string namaPerusahaanCabang, Alamat alamatPerusahaanCabang, string penanggungJawab)
        {
            return new DataPerusahaanCabang(dataPerusahaanId,namaPerusahaanCabang,alamatPerusahaanCabang,penanggungJawab);
        }
        private DataPerusahaanCabang(Guid dataPerusahaanId, string namaPerusahaanCabang, Alamat alamatPerusahaanCabang, string penanggungJawab)
        {
            DataPerusahaanCabangId = Guid.NewGuid();
            DataPerusahaanId = dataPerusahaanId;
            NamaPerusahaanCabang = namaPerusahaanCabang;
            AlamatPerusahaanCabang = alamatPerusahaanCabang;
            PenanggungJawab = penanggungJawab;
        }

        public Guid DataPerusahaanCabangId { get; set; }
        public int NoUrutId { get; set; }
        public Guid DataPerusahaanId { get; set; }
     
        public string NamaPerusahaanCabang { get; set; }

        public Alamat AlamatPerusahaanCabang { get; set; }

        public string PenanggungJawab { get; set; }
    }
}
