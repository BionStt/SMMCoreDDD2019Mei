using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
namespace SmmCoreDDD2019.Application.DataPerusahaans.Command.UpdateDataPerusahaan
{
   public class UpdateDataPerusahaanCommand:IRequest
    {
        public int KodeP { get; set; }
        public string NamaP { get; set; }
        public string AlamatP { get; set; }
        public string Kel { get; set; }
        public string Kec { get; set; }
        public string Kota { get; set; }
        public string KodePos { get; set; }
        public string Telp { get; set; }
        public string Cs { get; set; }


    }
}
