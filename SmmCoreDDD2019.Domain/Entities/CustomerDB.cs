using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmmCoreDDD2019.Domain.Entities
{
    public class CustomerDB : BaseEntity
    {
        //public CustomerDb()
        //{
        //    PenjualanDb = new HashSet<PenjualanDb>();
        //}

        //[ConcurrencyCheck]
        //[Timestamp]
        //public byte[] Version { get; set; }

        public string NoKodeCustomer { get; set; }
      //  public int CustomerID { get; set; }
        public string Alamat { get; set; }
        public string AlamatKirim { get; set; }
        public string Faks { get; set; }
        public string Handphone { get; set; }
        public string Jual { get; set; }
        public string Kecamatan { get; set; }
        public string Kelurahan { get; set; }
        public string KodePos { get; set; }
        public string Kota { get; set; }
        public string Propinsi { get; set; }
        public string Nama { get; set; }
        public string NamaBPKB { get; set; }
        public string NoKtp { get; set; }
       public string Email { get; set; }
        public string Telp { get; set; }
        public string TelpKantor { get; set; }
        public DateTime? TglInput { get; set; }
        public DateTime TglLahir { get; set; }
        public int? UserIDPeg { get; set; }
        public string UserInput { get; set; }
        public string KodeBidangPekerjaan { get; set; }
        public string NamaBidangPekerjaan { get; set; }
        public string KodeBidangUsaha { get; set; }
        public string NamaBidangUsaha { get; set; }

        // public ICollection<PenjualanDb> PenjualanDb { get; set; }
    }
}
