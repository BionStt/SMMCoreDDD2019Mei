using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.HumanCapital.Domain
{
    public class DataPegawaiAbsensi
    {
        public Guid DataPegawaiAbsensiId { get; set; }

        public Guid DataPegawaiId { get; set; }
        public Guid JenisAbsensi { get; set; }
        public DateTime JamAbsensiMasuk { get; set; }

        public DateTime JamAbsensiKeluar { get; set; }

        public string Keterangan { get; set; }
        public int NoUrutId { get; set; }
    }
}
