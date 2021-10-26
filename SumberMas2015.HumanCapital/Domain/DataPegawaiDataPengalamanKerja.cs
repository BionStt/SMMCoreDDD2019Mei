using SumberMas2015.HumanCapital.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.HumanCapital.Domain
{
    public class DataPegawaiDataPengalamanKerja
    {
        public Guid DataPegawaiDataPengalamanKerjaId { get; private set; }
        public Guid DataPegawaiId { get; private set; }

        public string NamaPerusahaan { get; private set; }
        public Alamat AlamatPerusahaan { get; private set; }

        public string JabatanAwal { get; private set; }
        public string JabatanTerakhir { get; private set; }
        public DateTime MulaiBekerja { get; private set; }
        public DateTime TerakhirBekerja { get; private set; }

        public Decimal GajiTerakhir { get; private set; }

        public string AtasanTerakhir { get; private set; }
        public DateTime TanggalInput { get; private set; }

        public string Keterangan { get; private set; }

    }
}
