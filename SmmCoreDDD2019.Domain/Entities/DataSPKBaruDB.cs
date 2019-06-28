using System;
using System.Collections.Generic;
using System.Text;

namespace SmmCoreDDD2019.Domain.Entities
{
 public class DataSPKBaruDB : BaseEntity
    {
        //public DataSpkbaruDb()
        //{
        //    DataSpkkendDb = new HashSet<DataSpkkendDb>();
        //    DataSpkkreditDb = new HashSet<DataSpkkreditDb>();
        //}

     //   public int NoUrutSPKBaru { get; set; }
        public string NoRegistrasiSPK { get; set; }
        public string LokasiSpk { get; set; }
        public string Terinput { get; set; }
        public DateTime? TglInput { get; set; }
        public string Tolak { get; set; }
        public int? UserIdpeg { get; set; }
        public string UserInput { get; set; }

        public ICollection<DataSPKKendaraanDB> DataSPKKendaraanDB { get; set; }
        public ICollection<DataSPKKreditDB> DataSPKKreditDB { get; set; }
        public ICollection<DataSPKLeasingDB> DataSPKLeasingDB { get; set; }
        public ICollection<DataSPKSurveiDB> DataSPKSurveiDB { get; set; }



}
}
