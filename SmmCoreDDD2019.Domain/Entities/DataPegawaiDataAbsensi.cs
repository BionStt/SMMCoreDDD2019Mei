using System;
using System.Collections.Generic;
using System.Text;

namespace SmmCoreDDD2019.Domain.Entities
{
    public class DataPegawaiDataAbsensi : BaseEntity
    {
      //  public int NoUrutAbsensi { get; set; }
        public int IDPegawai { get; set; }

        public string NoUrutJenisAbsensi { get; set; }
        public DateTime JamAbsensi { get; set; }

    }
}
