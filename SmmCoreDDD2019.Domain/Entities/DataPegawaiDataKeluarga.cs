using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SmmCoreDDD2019.Domain.Entities
{
   public class DataPegawaiDataKeluarga : BaseEntity
    {
        //public int NoUrut { get; set; }
    
        public int? IDPegawai { get; set; }
     
        public string NamaK { get; set; }
      
        public string AlamatK { get; set; }
     
        public string KelurahanK { get; set; }
      
        public string KecamatanK { get; set; }
     
        public string KotaK { get; set; }
        public string PropinsiK { get; set; }
       
        public string KodePosK { get; set; }
      
        public string Telp { get; set; }
     
        public string Handphone { get; set; }
      
        public string NoKtp { get; set; }
       
        public string HubunganK { get; set; }
       
        public string JenisKelamin { get; set; }
      
        public string TempatLahir { get; set; }
       
        public DateTime? Tgllahir { get; set; }
      
        public string PendidikanTerakhir { get; set; }
        public string Agama { get; set; }
        public string Pekerjaan { get; set; }
        public string Keterangan { get; set; }
        public string EmergencyCall { get; set; }
        public DateTime? TglInput { get; set; }
        public DataPegawai DataPegawai { get; set; }

    }
}
