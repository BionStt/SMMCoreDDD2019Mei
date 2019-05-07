using System;
using System.Collections.Generic;
using System.Text;

namespace SmmCoreDDD2019.Domain.Entities
{
   public class MasterKategoriBayaran
    {
        //public MasterKategoryBayaran()
        //{
        //    DataSpkleasingDb = new HashSet<DataSpkleasingDb>();
        //}

        public int NoUrut { get; set; }
        public string NamaKategoryBayaran { get; set; }
        
        public ICollection<DataSPKLeasingDB> DataSPKLeasingDB { get; private set; }
      //  public ICollection<DataSpkleasingDb> DataSpkleasingDb { get; set; }

    }
}
