using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Domain.Entities
{
    public class DataPegawaiJenisAbsensi : BaseEntity
    {
       // public int NoUrutJenisAbsensi { get; set; }
        public string JenisAbsensi { get; set; }
        public string Keterangan { get; set; }
        public DateTime JamMulai { get; set; }
        public DateTime JamBerakhir { get; set; }

    }
}
