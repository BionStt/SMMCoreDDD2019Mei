using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.DataSPKSurveiDBs.Command.UpdateDataSPKSurveiDB
{
    public class UpdateDataSPKSurveiDBCommand:IRequest
    {
        public int NoUrut { get; set; }
        public string AlamatPemesan { get; set; }
        public string HandphonePemesan { get; set; }
        public string KecamatanPemesan { get; set; }
        public string KelurahanPemesan { get; set; }
        public string KodePosPemesan { get; set; }
        public string KotaPemesan { get; set; }
        public string NamaNPWP { get; set; }
        public string NamaPemesan { get; set; }
        public string NoKtpPemesan { get; set; }
        public string NoNPWP { get; set; }
        public int? NoUrutSPKBaru { get; set; }
        public string PekerjaanPemesan { get; set; }
        public string PropinsiPemesan { get; set; }
        public string TelpPemesan { get; set; }
        //   public DataSPKBaruDB DataSPKBaruDB { get; set; }  
    }
}
