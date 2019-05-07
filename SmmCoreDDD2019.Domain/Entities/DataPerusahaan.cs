using System;
using System.Collections.Generic;
using System.Text;

namespace SmmCoreDDD2019.Domain.Entities
{
  public  class DataPerusahaan
    {
        //public ProfilP()
        //{
        //    DetailP = new HashSet<DetailP>();
        //}

        public int KodeP { get; set; }
        public string NoRegDataPerusahaan { get; set; }
        public string NamaP { get; set; }
        public string AlamatP { get; set; }
        public string Kel { get; set; }
        public string Kec { get; set; }
        public string Kota { get; set; }
        public string Propinsi { get; set; }
        public string KodePos { get; set; }
        public string Telp { get; set; }
        public string Cs { get; set; }

        public ICollection<DataPerusahaanCabang> DataPerusahaanCabang { get; private set; }

     //   public ICollection<DetailP> DetailP { get; set; }
    }
}
