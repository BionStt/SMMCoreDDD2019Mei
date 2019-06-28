using System;
using System.Collections.Generic;
using System.Text;

namespace SmmCoreDDD2019.Domain.Entities
{
   public class MasterKategoriBayaran : BaseEntity
    {
        //public MasterKategoryBayaran()
        //{
        //    DataSpkleasingDb = new HashSet<DataSpkleasingDb>();
        //}

      //  public int NoUrut { get; set; }
        public string NamaKategoryBayaran { get; set; }

        public DataSPKLeasingDB DataSPKLeasingDB { get; set; }
    }
}
