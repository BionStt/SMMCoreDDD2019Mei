using System;
using System.Collections.Generic;
using System.Text;

namespace SmmCoreDDD2019.Domain.Entities
{
   public class DataPerusahaanCabang
    {
        public int KodeP { get; set; }
        public int KodePosisi { get; set; }
        public string NamaPosisi { get; set; }
        public string Alamat { get; set; }
        public string Kel { get; set; }
        public string Kec { get; set; }
        public string Kota { get; set; }
        public string Propinsi { get; set; }
        public string KodePos { get; set; }
        public string Telp { get; set; }
        public string Cp { get; set; }
        public DataPerusahaan DataPerusahaan { get; set; }

        //   public ProfilP KodePNavigation { get; set; }

    }
}
