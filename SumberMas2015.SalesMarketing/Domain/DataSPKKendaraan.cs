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
        public Guid MasterBarangId { get; private set; }
        public Guid DataSPKId { get; private set; }
        protected DataSPKKendaraan()
        {

        }
        public static DataSPKKendaraan CreateDataSPKKendaraan(string tahunPerakitan, string warna, string namaSTNK, string noKtpSTNK,Guid masterBarangId, Guid dataSPKId)
        {
            return new DataSPKKendaraan(tahunPerakitan,warna,namaSTNK,noKtpSTNK,masterBarangId, dataSPKId);
        }
        private DataSPKKendaraan(string tahunPerakitan, string warna, string namaSTNK, string noKtpSTNK, Guid masterBarangId, Guid dataSPKId)
        {
            DataSPKKendaraanId = Guid.NewGuid();
            TahunPerakitan = tahunPerakitan;
            Warna = warna;
            NamaSTNK = namaSTNK;
            NoKtpSTNK = noKtpSTNK;
            MasterBarangId = masterBarangId;
            DataSPKId = dataSPKId;
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
