using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.HumanCapital.Domain
{
    public class DataPegawaiRiwayatPendidikan
    {
        public Guid DataPegawaiRiwayatPendidikanId { get; private set; }
        public Guid DataPegawaiId { get; private set; }

        public string TingkatPendidikan { get; private set; }
        public string NamaSekolah { get; private set; }
        public string Kota { get; private set; }
        public string Jurusan { get; private set; }
        public string TahunLulus { get; private set; }
        public string Keterangan { get; private set; }
    }
}
