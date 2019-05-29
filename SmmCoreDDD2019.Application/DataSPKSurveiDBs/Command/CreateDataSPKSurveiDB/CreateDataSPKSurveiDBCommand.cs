using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;
using System.ComponentModel.DataAnnotations;


namespace SmmCoreDDD2019.Application.DataSPKSurveiDBs.Command.CreateDataSPKSurveiDB
{
    public class CreateDataSPKSurveiDBCommand:IRequest
    {
      //  public int NoUrut { get; set; }
      //  public int? NoUrutSPKBaru { get; set; }
        [Display(Name = "Lokasi SPK")]
        public string LokasiSpk { get; set; }
        [Display(Name = "No KTP Pemesan")]
        public string NoKtpPemesan { get; set; }
        [Display(Name = "Nama Pemesan")]
        public string NamaPemesan { get; set; }
        [Display(Name = "Alamat")]
        public string AlamatPemesan { get; set; }
        [Display(Name = "Kelurahan")]
        public string KelurahanPemesan { get; set; }
        [Display(Name = "Kecamatan")]
        public string KecamatanPemesan { get; set; }
        [Display(Name = "Kota")]
        public string KotaPemesan { get; set; }
        [Display(Name = "Propinsi")]
        public string PropinsiPemesan { get; set; }
        [Display(Name = "Kode Pos")]
        public string KodePosPemesan { get; set; }
        [Display(Name = "Telepon")]
        public string TelpPemesan { get; set; }
        [Display(Name = "Handphone")]
        public string HandphonePemesan { get; set; }
        [Display(Name = "Pekerjaan")]
        public string PekerjaanPemesan { get; set; }
         [Display(Name = "No NPWP")]
        public string NoNPWP { get; set; }
        [Display(Name = "Nama NPWP")]
        public string NamaNPWP { get; set; }

        [Display(Name = "UserID")]
        public int? UserIdpeg { get; set; }
        [Display(Name = "User Input")]
        public string UserInput { get; set; }
      
     
      
     //   public DataSPKBaruDB DataSPKBaruDB { get; set; }
    }
}
