using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.DataKonsumen.Commands.UpdateDataKonsumen
{
    public class UpdateDataKonsumenCommand:IRequest
    {
        public int CustomerID { get; set; }
        [Display(Name = "Nomor KTP", Prompt = "Masukkan Nomor KTP dengan lengkap")]
        public string NoKtp { get; set; }
        [Display(Name = "Tanggal Lahir", Prompt = "Masukkan Tanggal Lahir")]
        [DataType(DataType.Text)]
        public DateTime TglLahir { get; set; }
        [Display(Name = "NamaDepan")]
        public string NamaDepan { get; set; }
        [Display(Name = "NamaBelakang")]
        public string NamaBelakang{ get; set; }
        [Display(Name = "Nama Depan BPKB")]
        public string NamaDepanBPKB { get; set; }
        [Display(Name = "Nama Belakang BPKB")]
        public string NamaBelakangBPKB { get; set; }
        [Display(Name = "Jalan", Prompt = "Masukan nama jalan")]
        public string Jalan { get; set; }
        [Display(Name = "Kelurahan", Prompt = "Masukan nama kelurahan")]
        public string Kelurahan { get; set; }
        [Display(Name = "Kecamatan", Prompt = "Masukan nama Kecamatan")]
        public string Kecamatan { get; set; }
        [Display(Name = "Kota", Prompt = "Masukan nama Kota")]
        public string Kota { get; set; }
        [Display(Name = "Propinsi", Prompt = "Masukan nama propinsi")]
        public string Propinsi { get; set; }
        [Display(Name = "Kode Pos", Prompt = "Masukan nama kode pos")]
        public string KodePos { get; set; }
        [Display(Name = "Nomor Telepon", Prompt = "Masukan nama nomor telepon")]
        public string NoTelepon { get; set; }
        [Display(Name = "nomor faks", Prompt = "Masukan nama faks")]
        public string NoFax { get; set; }
        [Display(Name = "Nomor Handphone", Prompt = "Masukan nama nomor handphone")]
        public string NoHandphone { get; set; }

        [Display(Name = "Jalan Pengiriman", Prompt = "Masukan nama jalan")]
        public string JalanKirim { get; set; }
        [Display(Name = "Kelurahan Pengiriman", Prompt = "Masukan nama kelurahan")]
        public string KelurahanKirim { get; set; }
        [Display(Name = "Kecamatan Pengiriman", Prompt = "Masukan nama Kecamatan")]
        public string KecamatanKirim { get; set; }
        [Display(Name = "Kota Pengiriman", Prompt = "Masukan nama Kota")]
        public string KotaKirim { get; set; }
        [Display(Name = "Propinsi Pengiriman", Prompt = "Masukan nama propinsi")]
        public string PropinsiKirim { get; set; }
        [Display(Name = "Kode Pos Pengiriman", Prompt = "Masukan nama kode pos")]
        public string KodePosKirim { get; set; }
        [Display(Name = "Nomor Telepon Pengiriman", Prompt = "Masukan nama nomor telepon")]
        public string NoTeleponKirim { get; set; }
        [Display(Name = "nomor faks Pengiriman", Prompt = "Masukan nama faks")]
        public string NoFaxKirim { get; set; }
        [Display(Name = "Nomor Handphone Pengiriman", Prompt = "Masukan nama nomor handphone")]
        public string NoHandphoneKirim { get; set; }

        //  public DateTime? TglInput { get; set; } 

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
        public string Jual { get; set; }
    }
}
