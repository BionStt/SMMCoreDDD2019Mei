using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;

using System.ComponentModel.DataAnnotations;

namespace SmmCoreDDD2019.Application.DataPegawaiDataPribadiInput.Command.CreateDataPegawaiDataPribadiInput
{
    public class CreateDataPegawaiDataPribadiInputCommand:IRequest
    {
       // public int IDPegawai { get; set; }
        //[Display(Name = "Tanggal Input")]
        //public DateTime? TglInput { get; set; }
 
        public DateTime? TglMulaiKerja { get; set; }
  
        public DateTime? TglBerhentiKerja { get; set; }
        public string Aktif { get; set; }

        //  public int? IDPegawai { get; set; }
        [Display(Name = "No KTP", Prompt = "Masukkan Nomor KTP")]
        public string NoKTP { get; set; }

        [Display(Name = "Nama Depan")]
        public string NamaDepan { get; set; }
        [Display(Name = "Nama Tengah")]
        public string NamaTengah { get; set; }
        [Display(Name = "Nama Belakang")]
        public string NamaBelakang { get; set; }

       [Display(Name = "Alamat KTP")]
        public string AlamatKTP { get; set; }
        [Display(Name = "Kelurahan")]
        public string KelurahanKTP { get; set; }
        [Display(Name = "Kecamatan")]
        public string KecamatanKTP { get; set; }
        [Display(Name = "Kota")]
        public string KotaKTP { get; set; }
        [Display(Name = "Propinsi")]
        public string PropinsiKTP { get; set; }

        [Display(Name = "Kode Pos")]
        public string KodePosKTP { get; set; }

        [Display(Name = "Alamat Rumah")]
        public string AlamatRumah { get; set; }
        [Display(Name = "Kelurahan")]
        public string KelurahanRumah { get; set; }
        [Display(Name = "Kecamatan")]
        public string KecamatanRumah { get; set; }
        [Display(Name = "Kota")]
        public string KotaRumah { get; set; }
        [Display(Name = "Propinsi")]
        public string PropinsiRumah { get; set; }
        [Display(Name = "Kode Pos")]
        public string KodePos { get; set; }
        [Display(Name = "Telepon")]
        public string Telp { get; set; }
        [Display(Name = "Mobile Phone 1")]
        public string Handphone { get; set; }
        [Display(Name = "Mobile Phone 2")]
        public string Handphone2 { get; set; }
        [Display(Name = "Agama")]
        public string Agama { get; set; }
        [Display(Name = "Tempat Lahir")]
        public string TempatLahir { get; set; }
        [Display(Name = "Tanggal Lahir"), DataType(DataType.Text)]
        public DateTime? TanggalLahir { get; set; }
        [Display(Name = "Jenis Kelamin")]
        public string JenisKelamin { get; set; }
        [Display(Name = "Status Pernikahan")]
        public string StatusKawin { get; set; }
        [Display(Name = "Golongan Darah ")]
        public string GolonganDarah { get; set; }
        [Display(Name = "Status Tempat Tinggal")]
        public string StatusTempatTinggal { get; set; }
        [Display(Name = "Email", Prompt ="Contoh : abcde@gmail.com")]
        public string Email { get; set; }

    }
}
