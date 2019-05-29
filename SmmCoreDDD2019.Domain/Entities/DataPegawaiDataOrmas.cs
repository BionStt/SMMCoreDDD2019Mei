﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SmmCoreDDD2019.Domain.Entities
{
   public class DataPegawaiDataOrmas
    {
        public int NoUrut { get; set; }
        public int? IDPegawai { get; set; }
        public string NamaOrmas { get; set; }
        public string AlamatOrmas { get; set; }
        public string KotaOrmas { get; set; }
        public string TelpOrmas { get; set; }
        public string Jabatan { get; set; }
        public string JenisKegiatan { get; set; }
        public DateTime? TglInput { get; set; }
        public DataPegawai DataPegawai { get; set; }
    }
}