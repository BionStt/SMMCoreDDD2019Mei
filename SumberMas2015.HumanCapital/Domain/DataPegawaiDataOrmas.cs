using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.HumanCapital.Domain
{
    public class DataPegawaiDataOrmas
    {
        public Guid DataPegawaiDataOrmasId { get; private set; }

        public Guid DataPegawaiId { get; private set; }


        public string NamaOrmas { get; private set; }
        public string AlamatOrmas { get; private set; }
        public string KotaOrmas { get; private set; }
        public string TelpOrmas { get; private set; }
        public string Jabatan { get; private set; }
        public string JenisKegiatan { get; private set; }
        public DateTime TanggalInput { get; private set; }

    }
}
