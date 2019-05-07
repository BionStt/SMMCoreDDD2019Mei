using System;
using System.Collections.Generic;
using System.Text;

namespace SmmCoreDDD2019.Domain.Entities
{
   public class MasterLeasingDb
    {

        //public NamaLease()
        //{
        //    DataSpkleasingDb = new HashSet<DataSpkleasingDb>();
        //    PenjualanDb = new HashSet<PenjualanDb>();
        //}

        public int IDlease { get; set; }
        public string NamaLease { get; set; }
        public ICollection<MasterLeasingCabangDB> MasterLeasingCabangDB { get; private set; }
      

        // public ICollection<DataSpkleasingDb> DataSpkleasingDb { get; set; }
        // public ICollection<PenjualanDb> PenjualanDb { get; set; }


    }
}
