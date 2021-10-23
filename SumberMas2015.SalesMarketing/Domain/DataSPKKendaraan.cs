
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Domain
{
    public class DataSPKKendaraan
    {
        public Guid DataSPKKendaraanId { get; set; }
        public string TahunPerakitan { get; private set; }
        public string Warna { get; private set; }
        public string NamaSTNK { get; private set; }
        public string NoKtpSTNK { get; private set; }
        public int NoUrutId { get; set; }
        public MasterBarang MasterBarang { get; private set; }
        public DataSPK DataSPK { get; private set; }
        protected DataSPKKendaraan()
        {

        }
        public DataSPKKendaraan(string tahunPerakitan, string warna, string namaSTNK, string noKtpSTNK)
        {
            DataSPKKendaraanId = Guid.NewGuid();
            TahunPerakitan = tahunPerakitan;
            Warna = warna;
            NamaSTNK = namaSTNK;
            NoKtpSTNK = noKtpSTNK;
        }
        public void EditDataSPKKendaraan(string tahunPerakitan, string warna, string namaSTNK, string noKtpSTNK)
        {
            TahunPerakitan = tahunPerakitan;
            Warna = warna;
            NamaSTNK = namaSTNK;
            NoKtpSTNK = noKtpSTNK;
        }

    }
}
