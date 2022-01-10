using SumberMas2015.SalesMarketing.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required]
        public DataNPWP DataNPWPPemesan { get; private set; }
        public string PekerjaanPemesan { get; private set; }
        public int NoUrutId { get; set; }

        public Guid DataSPKId { get; private set; }


        public DataSPKSurvei()
        {

        }
        public static DataSPKSurvei CreateDataSPKSurvei(string noKTPPemesan, Name namaPemesan, Alamat alamatPemesan, DataNPWP dataNPWPPemesan, string pekerjaanPemesan, Guid dataSPKId)
        {
            return new DataSPKSurvei(noKTPPemesan,namaPemesan, alamatPemesan, dataNPWPPemesan,pekerjaanPemesan, dataSPKId);
        }
        private DataSPKSurvei(string noKTPPemesan, Name namaPemesan, Alamat alamatPemesan, DataNPWP dataNPWPPemesan, string pekerjaanPemesan, Guid dataSPKId)
        {
            DataSPKSurveiId = Guid.NewGuid();
            NoKTPPemesan = noKTPPemesan;
            NamaPemesan = namaPemesan;
            AlamatPemesan = alamatPemesan;
            DataNPWPPemesan = dataNPWPPemesan;
            PekerjaanPemesan = pekerjaanPemesan;
            DataSPKId = dataSPKId;
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
