using System;
using System.Collections.Generic;
using System.Text;

namespace SmmCoreDDD2019.Domain.Entities
{
    public class DataPegawaiDataAbsensi : BaseEntity
    {
      //  public int NoUrutAbsensi { get; set; }
        public int DataPegawaiId { get; set; }

        public string DataPegawaiJenisAbsensiId { get; set; }
        public DateTime JamAbsensi { get; set; }

    }
}
