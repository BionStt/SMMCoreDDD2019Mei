using System;
using System.Collections.Generic;
using System.Text;

namespace SmmCoreDDD2019.Domain.Entities
{
   public class DataPegawaiDataRiwayatPendidikan : BaseEntity
    {
       // public int NoUrut { get; set; }
        public int? DataPegawaiId { get; set; }
        public string TingkatPend { get; set; }
        public string NamaSekolah { get; set; }
        public string Kota { get; set; }
        public string Jurusan { get; set; }
        public int? TahunLulus { get; set; }
        public string Keterangan { get; set; }
        public DataPegawai DataPegawai { get; set; }

    }
}
