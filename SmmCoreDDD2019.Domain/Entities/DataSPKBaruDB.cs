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

        public DataSPKKendaraanDB DataSPKKendaraanDB { get; set; }
        public Penjualan Penjualan { get; set; }
        public DataSPKSurveiDB DataSPKSurveiDB { get; set; }
        public DataSPKLeasingDB DataSPKLeasingDB { get; set; }
        public DataSPKKreditDB DataSPKKreditDB { get; set; }






}
}
