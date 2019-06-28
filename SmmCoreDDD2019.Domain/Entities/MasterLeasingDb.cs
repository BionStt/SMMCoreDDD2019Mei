using System;
using System.Collections.Generic;
using System.Text;

namespace SmmCoreDDD2019.Domain.Entities
{
   public class MasterLeasingDb : BaseEntity
    {

        //public NamaLease()
        //{
        //    DataSpkleasingDb = new HashSet<DataSpkleasingDb>();
        //    PenjualanDb = new HashSet<PenjualanDb>();
        //}

       // public int IDlease { get; set; }
        public string NamaLease { get; set; }
       
        public MasterLeasingCabangDB MasterLeasingCabangDB { get; set; }
        // public ICollection<DataSpkleasingDb> DataSpkleasingDb { get; set; }
        // public ICollection<PenjualanDb> PenjualanDb { get; set; }


    }
}
