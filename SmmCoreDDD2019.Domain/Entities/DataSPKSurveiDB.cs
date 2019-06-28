using System;
using System.Collections.Generic;
using System.Text;

namespace SmmCoreDDD2019.Domain.Entities
{
   public class DataSPKSurveiDB : BaseEntity
    {
       // public int NoUrut { get; set; }
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
        public int? DataSPKBaruDBId{ get; set; }
        public string PekerjaanPemesan { get; set; }
        public string PropinsiPemesan { get; set; }
        public string TelpPemesan { get; set; }
      


    }
}
