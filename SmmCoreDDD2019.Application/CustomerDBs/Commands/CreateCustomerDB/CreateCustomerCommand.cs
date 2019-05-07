using System;
using System.Collections.Generic;
using System.Text;

using System.Threading;
using System.Threading.Tasks;
using MediatR;
using System.ComponentModel.DataAnnotations;
namespace SmmCoreDDD2019.Application.CustomerDBs.Commands.CreateCustomerDB
{
   public  class CreateCustomerCommand :IRequest
    {
     //   public int CustomerID { get; set; }
     [Display(Name ="Alamat")]
        public string Alamat { get; set; }
        [Display(Name = "Alamat Pengiriman")]
        public string AlamatKirim { get; set; }
        [Display(Name = "Faks")]
        public string Faks { get; set; }
        [Display(Name = "Handphone")]
        public string Handphone { get; set; }
        public string Jual { get; set; }
        [Display(Name = "Kecamatan")]
        public string Kecamatan { get; set; }
        [Display(Name = "Kelurahan")]
        public string Kelurahan { get; set; }
        [Display(Name = "Kode Pos")]
        public string KodePos { get; set; }
        [Display(Name = "Kota")]
        public string Kota { get; set; }
        [Display(Name = "Propinsi")]
        public string Propinsi { get; set; }
        [Display(Name = "Nama")]
        public string Nama { get; set; }
        [Display(Name = "Nama BPKB")]
        public string NamaBPKB { get; set; }
        [Display(Name = "Nomor KTP",Prompt ="Masukkan Nomor KTP dengan lengkap")]
        public string NoKtp { get; set; }
      
        [Display(Name = "Telepon")]
        public string Telp { get; set; }
        [Display(Name = "Telepon Kantor")]
        public string TelpKantor { get; set; }
        //  public DateTime? TglInput { get; set; } 
        [Display(Name ="Tanggal Lahir",Prompt ="Masukkan Tanggal Lahir")]
        [DataType(DataType.Text)]
        public DateTime TglLahir { get; set; }
        [Display(Name = "Bidang Pekerjaan")]
        public string KodeBidangPekerjaan { get; set; }
        [Display(Name = "Nama Pekerjaan")]
        public string NamaBidangPekerjaan { get; set; }
        [Display(Name = "Bidang Usaha")]
        public string KodeBidangUsaha { get; set; }
        [Display(Name = "Jenis Usaha")]
        public string NamaBidangUsaha { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        public int? UserIDPeg { get; set; }
     
        public string UserInput { get; set; }

    }
}
