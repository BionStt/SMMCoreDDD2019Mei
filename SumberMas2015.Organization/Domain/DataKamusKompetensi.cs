using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Organization.Domain
{
    public class DataKamusKompetensi
    {
        public Guid DataKamusKompetensiId { get; set; }

        public int NoUrutId { get; set; }
        public string NamaKamusKompetensi { get; set; }
        public string Penjelasan { get; set; }
    }
}
