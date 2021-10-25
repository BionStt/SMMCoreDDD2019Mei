using SumberMas2015.SalesMarketing.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Domain
{
    public class DataSPKSurvei
    {
        public Guid DataSPKSurveiId { get; set; }
        public string NoKTPPemesan { get; private set; }
        public Name NamaPemesan { get; private set; }
        public Alamat AlamatPemesan { get; private set; }
        public DataNPWP DataNPWPPemesan { get; private set; }
        public string PekerjaanPemesan { get; private set; }
        public int NoUrutId { get; set; }

        public DataSPK DataSPK { get; private set; }


        public DataSPKSurvei()
        {

        }

        public DataSPKSurvei(string noKTPPemesan, Name namaPemesan, Alamat alamatPemesan, DataNPWP dataNPWPPemesan, string pekerjaanPemesan)
        {
            DataSPKSurveiId = Guid.NewGuid();
            NoKTPPemesan = noKTPPemesan;
            NamaPemesan = namaPemesan;
            AlamatPemesan = alamatPemesan;
            DataNPWPPemesan = dataNPWPPemesan;
            PekerjaanPemesan = pekerjaanPemesan;
        }
        public void EditDataSPKSurvei(string noKTPPemesan, Name namaPemesan, Alamat alamatPemesan, DataNPWP dataNPWPPemesan, string pekerjaanPemesan)
        {
            NoKTPPemesan = noKTPPemesan;
            NamaPemesan = namaPemesan;
            AlamatPemesan = alamatPemesan;
            DataNPWPPemesan = dataNPWPPemesan;
            PekerjaanPemesan = pekerjaanPemesan;
        }


    }
}
