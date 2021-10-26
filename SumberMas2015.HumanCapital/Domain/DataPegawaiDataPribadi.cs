using SumberMas2015.HumanCapital.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.HumanCapital.Domain
{
    public class DataPegawaiDataPribadi
    {
        public Guid DataPegawaiDataPribadiId { get; private set; }

        public Guid DataPegawaiId { get; private set; }


        public Name NamaPegawai { get; private set; }
        public Alamat AlamatPegawai { get; private set; }
        public string NomorKTPPegawai { get; private set; }
        public Alamat AlamatPegawaiKTP { get; private set; }
        public DateTime TanggalLahirPegawai { get; private set; }

        public Guid JenisKelamin { get; private set; }
        public Guid Agama { get; private set; }

        public Guid StatusPerkawinan { get; private set; }
        public string GolonganDarah { get; private set; }
        public Guid StatusTempatTinggal { get; private set; }
        public string EmailPegawai { get; private set; }

        public DateTime TanggalInput { get; private set; }

        public int NoUrutId { get; set; }

    }
}
