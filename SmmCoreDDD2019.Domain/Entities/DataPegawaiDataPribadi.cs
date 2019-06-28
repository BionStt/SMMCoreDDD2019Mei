using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace SmmCoreDDD2019.Domain.Entities
{
   public class DataPegawaiDataPribadi : BaseEntity
    {

      //  public int NoUrut { get; set; }
      
        public int? DataPegawaiId { get; set; }

       
        public string NamaDepan { get; set; }
      
        public string NamaTengah { get; set; }
     
        public string NamaBelakang { get; set; }

      
        public string AlamatRumah { get; set; }
      
        public string KelurahanRumah { get; set; }
      
        public string KecamatanRumah { get; set; }
      
        public string KotaRumah { get; set; }
        public string PropinsiRumah { get; set; }
      
        public string KodePos { get; set; }
      
        public string AlamatKTP { get; set; }
       
        public string KelurahanKTP { get; set; }
      
        public string KecamatanKTP { get; set; }
      
        public string KotaKTP { get; set; }
        public string PropinsiKTP { get; set; }
      
        public string KodePosKTP { get; set; }
      
        public string NoKTP { get; set; }
      
        public string Telp { get; set; }
      
        public string Handphone { get; set; }
       
        public string Handphone2 { get; set; }
        public string Agama { get; set; }
      
        public string TempatLahir { get; set; }
       
        public DateTime? TanggalLahir { get; set; }
      
        public string JenisKelamin { get; set; }
      
        public string StatusKawin { get; set; }
       
        public string GolonganDarah { get; set; }
       
        public string StatusTempatTinggal { get; set; }
        public string Email { get; set; }
       
        public DateTime? TglInput { get; set; }
        public DataPegawai DataPegawai { get; set; }

    }
}
