using System;
using System.Collections.Generic;
using System.Text;

namespace SmmCoreDDD2019.Domain.Entities
{
   public class DataSPKKendaraanDB : BaseEntity
    {
      //  public int NoUrut { get; set; }
        public string NamaSTNK { get; set; }
        public string NoKtpSTNK { get; set; }
        public int? MasterBarangDBId { get; set; }
        public int? DataSPKBaruDBId { get; set; }
        public string TahunPerakitan { get; set; }
        public string Warna { get; set; }
      
      
    }
}
