﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SmmCoreDDD2019.Domain.Entities
{
  public  class DataPegawaiDataRiwayatPekerjaan : BaseEntity
    {
       // public int NoUrut { get; set; }
       
        public int? IDPegawai { get; set; }
     
        public string NamaPerusahaan { get; set; }
      
        public string AlamatP { get; set; }
       
        public string KelurahanP { get; set; }
       
        public string KecamatanP { get; set; }
      
        public string KotaP { get; set; }
        public string PropinsiP { get; set; }

       
        public string KodePosP { get; set; }
      
        public string TelpP { get; set; }
       
        public string JabatanAwal { get; set; }
     
        public string JabatanAkhir { get; set; }
      
        public DateTime? MulaiBekerja { get; set; }
      
        public DateTime? AkhirBekerja { get; set; }
      
        public decimal? GajiTerakhir { get; set; }
      
        public string AtasanP { get; set; }
        public DateTime? TglInput { get; set; }
        public string Keterangan { get; set; }
        public DataPegawai DataPegawai { get; set; }
    }
}
