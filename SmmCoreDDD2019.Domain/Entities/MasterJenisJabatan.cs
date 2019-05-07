using System;
using System.Collections.Generic;
using System.Text;

namespace SmmCoreDDD2019.Domain.Entities
{
   public  class MasterJenisJabatan
    {
        public int NoUrut { get; set; }
        public string NamaJabatan { get; set; }

        public ICollection<DataPegawaiDataJabatan> DataPegawaiDataJabatan { get; private set; }

    }
}
