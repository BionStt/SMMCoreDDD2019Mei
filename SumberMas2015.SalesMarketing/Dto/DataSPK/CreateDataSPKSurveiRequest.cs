using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Dto.DataSPK
{
    public class CreateDataSPKSurveiRequest
    {
        public string UserInput { get; set; }
        public string UserInputName { get; set; }
        public string NomorKTPPemesan { get; set; }
        public string LokasiSPK { get; set; }
        public string NamaDepan { get; set; }
        public string NamaBelakang { get; set; }
        public string Jalan { get;  set; }
        public string Kelurahan { get;  set; }
        public string Kecamatan { get;  set; }
        public string Kota { get; internal set; }
        public string Propinsi { get;  set; }
        public string KodePos { get; set; }
        public string NomorTelepon { get; set; }
        public string NomorHandphone { get; set; }
        public string NomorFaks { get; set; }
        public string PekerjaanPemesan { get;  set; }
        public string NomorNPWP { get;  set; }
        public string NamaNPWP { get;  set; }
        public string JalanNPWP { get;  set; }
        public string KelurahanNPWP { get;  set; }
        public string KecamatanNPWP { get;  set; }
        public string KotaNPWP { get;  set; }
        public string PropinsiNPWP { get;  set; }
        public string KodePosNPWP { get;  set; }
        public string NomorTeleponNPWP { get;  set; }
        public string NomorFaksNPWP { get;  set; }
        public string NomorHandphoneNPWP { get;  set; }
        public int DataSPKId { get;  set; }
    }
}
