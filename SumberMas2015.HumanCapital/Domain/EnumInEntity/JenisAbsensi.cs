using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.HumanCapital.Domain.EnumInEntity
{
    public class JenisAbsensi
    {
        public Guid JenisAbsensiId { get; set; }

        public string NamaJenisAbsensi { get; set; }
        public string Keterangan { get; set; }
        public DateTime JamMulai { get; set; }
        public DateTime JamBerakhir { get; set; }
        public int NoUrutId { get; set; }

          //'Absen Pagi',
          //  'Absen Istrahat',
          //  'Absen Siang',
          //  'Absen Pulang'


    }
}
