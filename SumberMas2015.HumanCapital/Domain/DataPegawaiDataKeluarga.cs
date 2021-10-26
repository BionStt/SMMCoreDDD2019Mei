using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.HumanCapital.Domain
{
    public class DataPegawaiDataKeluarga
    {
        public Guid DataPegawaiDataKeluargaId { get; private set; }
        public Guid DataPegawaiId { get; private set; }

        public Name NamaKeluarga { get; private set; }
        public Alamat AlamatKeluarga { get; private set; }
        public string NoKTPKeluarga { get; private set; }
        public Guid StatusHubunganKeluarga { get; private set; }

        public Guid JenisKelamin { get; private set; }

        public string TempatLahirKeluarga { get; private set; }
        public DateTime TanggalLahirKeluarga { get; private set; }
        public string PendidikanTerakhir { get; private set; }
        public string PekerjaanKeluarga { get; private set; }
        public Guid Agama { get; private set; }
        public string PanggilanDarurat { get; private set; }


        public DateTime TanggalInput { get; private set; }
        public int NoUrutId { get; set; }
    }
}
