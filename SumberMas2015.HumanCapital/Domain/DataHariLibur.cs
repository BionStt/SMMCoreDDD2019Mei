using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.HumanCapital.Domain
{
    public class DataHariLibur
    {
        public Guid DataHariLiburId { get; set; }
        public int NoUrutId { get; set; }
        public string NamaHariLibur { get; set; }
        public string Keterangan { get; set; }
        public DateTime PeriodeAwalLibur{ get; set; }
        public DateTime PeriodeAkhirLibur { get; set; }
        public int JumlahHariLibur { get; set; }
        public string Tahun { get; set; }


    }
}
