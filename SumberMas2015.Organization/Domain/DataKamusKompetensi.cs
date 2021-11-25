using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Organization.Domain
{
    public class DataKamusKompetensi
    {
        public static DataKamusKompetensi CreateDataKamusKompetensi(string namaKamusKompetensi, string penjelasan) 
        {
            return new DataKamusKompetensi(namaKamusKompetensi, penjelasan);
        }
        private DataKamusKompetensi(string namaKamusKompetensi, string penjelasan)
        {
            DataKamusKompetensiId = Guid.NewGuid();
            NamaKamusKompetensi =namaKamusKompetensi;
            Penjelasan=penjelasan;
            TanggalInput=DateTime.Now;
        }

        public Guid DataKamusKompetensiId { get; set; }

    
        public string NamaKamusKompetensi { get; set; }
        public string Penjelasan { get; set; }
        public DateTime TanggalInput{ get; set; }

        public int NoUrutId { get; set; }
    }
}
