﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SmmCoreDDD2019.Domain.Entities
{
   public class DataPegawaiDataRiwayatPelatihan
    {
        public int NoUrut { get; set; }
        public int? IDPegawai { get; set; }
        public string NamaLembaga { get; set; }
        public string AlamatLembaga { get; set; }
        public string TelpLembaga { get; set; }
        public string LamaKursus { get; set; }
        public string DibiayaiOleh { get; set; }
        public string BidangPelatihan { get; set; }
        public DataPegawai DataPegawai { get; set; }
    }
}