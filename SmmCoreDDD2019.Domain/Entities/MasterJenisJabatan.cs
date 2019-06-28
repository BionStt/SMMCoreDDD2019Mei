using System;
using System.Collections.Generic;
using System.Text;

namespace SmmCoreDDD2019.Domain.Entities
{
   public  class MasterJenisJabatan : BaseEntity
    {
       // public int NoUrut { get; set; }
        public string NamaJabatan { get; set; }

        public DataPegawaiDataJabatan DataPegawaiDataJabatan { get; set; }
     
    }
}
