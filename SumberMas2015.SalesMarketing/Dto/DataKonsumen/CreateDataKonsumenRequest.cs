
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Dto.DataKonsumen
{
    public class CreateDataKonsumenRequest
    {
        [Display(Name = "Jalan", Prompt = "Masukan nama jalan")]
        public string Jalan{ get; set; }
        [Display(Name = "Kelurahan", Prompt = "Masukan nama kelurahan")]
        public string Kelurahan{ get; set; }
        [Display(Name = "Kecamatan", Prompt = "masukan nama kecamatan")]
        public string Kecamatan{ get; set; }
        [Display(Name = "Kota", Prompt = "Masukan nama kota")]
        public string Kota{ get; set; }
        [Display(Name = "Propinsi", Prompt = "Masukan nama propinsi")]
        public string Propinsi{ get; set; }
        [Display(Name = "Kode Pos", Prompt = "Masukan kode pos")]
        public string KodePos{ get; set; }
        [Display(Name = "Nomor Telepon", Prompt = "Masukan nomor telepon contoh: 0217338398")]
        public string NomorTelepon{ get; set; }
        [Display(Name = "Nomor Faks", Prompt = "Masukan nomor Faks")]
        public string NomorFaks{ get; set; }
        [Display(Name = "Nomor Handphone", Prompt = "Masukan nomor handphone")]
        public string NomorHandphone{ get; set; }

        [Display(Name = "Jalan Kirim", Prompt = "Masukan nama jalan kirim")]
        public string JalanKirim { get; set; }
        [Display(Name = "Kelurahan", Prompt = "")]
        public string KelurahanKirim { get; set; }
        [Display(Name = "Kecamatan", Prompt = "")]
        public string KecamatanKirim { get; set; }
        [Display(Name = "Kota", Prompt = "")]
        public string KotaKirim { get; set; }
        [Display(Name = "Propinsi", Prompt = "")]
        public string PropinsiKirim { get; set; }
        [Display(Name = "Kode Pos", Prompt = "")]
        public string KodePosKirim { get; set; }
        [Display(Name = "Nomo Telepon", Prompt = "")]
        public string NomorTeleponKirim { get; set; }
        [Display(Name = "Nomor Faks", Prompt = "")]
        public string NomorFaksKirim { get; set; }
        [Display(Name = "Nomor Handphone", Prompt = "")]
        public string NomorHandphoneKirim { get; set; }
        [Display(Name = "Nama Depan", Prompt = "MAsukan nama depan")]
        public string NamaDepan { get; set; }
        [Display(Name = "Nama Belakang", Prompt = "Masukan nama belakang")]
        public string NamaBelakang { get; set; }
        [Display(Name ="Nama Depan BPKB", Prompt ="Masukan nama depan BPKB")]
        public string NamaDepanBPKB { get; set; }
        [Display(Name ="Nama Belakang BPKB", Prompt ="Masukan nama belakang BPKB")]
        public string NamaBelakangBPKB { get; set; }

        [Display(Name = "Nomor KTP", Prompt = "Masukkan Nomor KTP dengan lengkap")]
        public string NomorKtp { get; set; }
        [Display(Name ="Jenis Kelamin")]
        public int JenisKelamin { get; set; }
        [Display(Name = "Agama")]
        public int Agama { get; set; }

        [Display(Name = "Tanggal Lahir", Prompt = "Masukkan Tanggal Lahir")]
       // [DataType(DataType.Text)]
        public DateTime TangggalLahir { get; set; }
        [Display(Name = "Bidang Pekerjaan")]
        public int KodeBidangPekerjaan { get; set; }
        [Display(Name = "Nama Pekerjaan")]
        public string NamaBidangPekerjaan { get; set; }
        [Display(Name = "Bidang Usaha")]
        public int KodeBidangUsaha { get; set; }
        [Display(Name = "Jenis Usaha")]
        public string NamaBidangUsaha { get; set; }
        [Display(Name = "Email",Prompt ="Contoh : sumbermas@gmail.com")]
        public string Email { get; set; }
      //  public string UserIDPeg { get; set; }

        public string UserName { get; set; }
        public Guid UserNameId { get; set; }
    }
}
