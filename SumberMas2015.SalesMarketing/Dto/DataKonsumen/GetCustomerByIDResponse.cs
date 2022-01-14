using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Dto.DataKonsumen
{
    public class GetCustomerByIDResponse
    {
        //  public int NoUrutKendaraan { get; set; }
        public string NoKodeCustomer { get; set; }
        public int CustomerID { get; set; }
        [Display(Name = "Jalan", Prompt = "Masukan nama jalan")]
        public string Jalan { get;  set; }
        [Display(Name = "Kelurahan", Prompt = "Masukan nama kelurahan")]
        public string Kelurahan { get;  set; }
        [Display(Name = "Kecamatan", Prompt = "Masukan nama Kecamatan")]
        public string Kecamatan { get;  set; }
        [Display(Name = "Kota", Prompt = "Masukan nama Kota")]
        public string Kota { get;  set; }
        [Display(Name = "Propinsi", Prompt = "Masukan nama propinsi")]
        public string Propinsi { get;  set; }
        [Display(Name = "Kode Pos", Prompt = "Masukan nama kode pos")]
        public string KodePos { get;  set; }
        [Display(Name = "Nomor Telepon", Prompt = "Masukan nama nomor telepon")]
        public string NoTelepon { get;  set; }
        [Display(Name = "nomor faks", Prompt = "Masukan nama faks")]
        public string NoFax { get;  set; }
        [Display(Name = "Nomor Handphone", Prompt = "Masukan nama nomor handphone")]
        public string NoHandphone { get;  set; }
     
        [Display(Name = "Jalan Pengiriman", Prompt = "Masukan nama jalan")]
        public string JalanKirim { get;  set; }
        [Display(Name = "Kelurahan Pengiriman", Prompt = "Masukan nama kelurahan")]
        public string KelurahanKirim { get;  set; }
        [Display(Name = "Kecamatan Pengiriman", Prompt = "Masukan nama Kecamatan")]
        public string KecamatanKirim { get;  set; }
        [Display(Name = "Kota Pengiriman", Prompt = "Masukan nama Kota")]
        public string KotaKirim { get;  set; }
        [Display(Name = "Propinsi Pengiriman", Prompt = "Masukan nama propinsi")]
        public string PropinsiKirim { get;  set; }
        [Display(Name = "Kode Pos Pengiriman", Prompt = "Masukan nama kode pos")]
        public string KodePosKirim { get;  set; }
        [Display(Name = "Nomor Telepon Pengiriman", Prompt = "Masukan nama nomor telepon")]
        public string NoTeleponKirim { get;  set; }
        [Display(Name = "nomor faks Pengiriman", Prompt = "Masukan nama faks")]
        public string NoFaxKirim { get;  set; }
        [Display(Name = "Nomor Handphone Pengiriman", Prompt = "Masukan nama nomor handphone")]
        public string NoHandphoneKirim { get;  set; }
       
       
        public string Jual { get; set; }
    
        public string Nama { get; set; }
        public string NamaBPKB { get; set; }
        public string NoKtp { get; set; }
        public string Email { get; set; }
   
        public string TelpKantor { get; set; }
        public DateTime? TglInput { get; set; }
        public DateTime TglLahir { get; set; }
        public int? UserIDPeg { get; set; }
        public string UserInput { get; set; }
        public string KodeBidangPekerjaan { get; set; }
        public string NamaBidangPekerjaan { get; set; }
        public string KodeBidangUsaha { get; set; }
        public string NamaBidangUsaha { get; set; }
    }
}
