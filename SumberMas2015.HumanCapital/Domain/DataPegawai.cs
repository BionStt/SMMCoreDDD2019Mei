using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.HumanCapital.Domain
{
    public class DataPegawai
    {
        public Guid DataPegawaiId { get; private set; }

        public string NomorRegistrasiPegawai { get; private set; }
        public DateTime TanggalPegawaiBergabung { get; private set; }
        public DateTime TanggaPegawaiBerhenti { get; private set; }
        public DateTime TanggalInput { get; private set; }
        public int NoUrutId { get; set; }


        public string StatusAktifPegawai { get; private set; }


    }
}
