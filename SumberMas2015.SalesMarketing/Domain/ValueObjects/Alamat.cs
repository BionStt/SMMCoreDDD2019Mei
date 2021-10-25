
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Domain.ValueObjects
{
    public class Alamat
    {
        [Display(Name = "Jalan", Prompt ="Masukan nama jalan")]
        public string Jalan { get; private set; }
        [Display(Name = "Kelurahan", Prompt = "Masukan nama kelurahan")]
        public string Kelurahan { get; private set; }
        [Display(Name = "Kecamatan", Prompt = "Masukan nama Kecamatan")]
        public string Kecamatan { get; private set; }
        [Display(Name = "Kota", Prompt = "Masukan nama Kota")]
        public string Kota { get; private set; }
        [Display(Name = "Propinsi", Prompt = "Masukan nama propinsi")]
        public string Propinsi { get; private set; }
        [Display(Name = "Kode Pos", Prompt = "Masukan nama kode pos")]
        public string KodePos { get; private set; }
        [Display(Name = "Nomor Telepon", Prompt = "Masukan nama nomor telepon")]
        public string NoTelepon { get; private set; }
        [Display(Name = "nomor faks", Prompt = "Masukan nama faks")]
        public string NoFax { get; private set; }
        [Display(Name = "Nomor Handphone", Prompt = "Masukan nama nomor handphone")]
        public string NoHandphone { get; private set; }
        protected Alamat()
        {

        }

        private Alamat(string jalan, string kelurahan, string kecamatan, string kota, string propinsi, string kodePos, string noTelepon, string noFax, string noHandphone)
        {
            Jalan = jalan;
            Kelurahan = kelurahan;
            Kecamatan = kecamatan;
            Kota = kota;
            Propinsi = propinsi;
            KodePos = kodePos;
            NoTelepon = noTelepon;
            NoFax = noFax;
            NoHandphone = noHandphone;
        }
        public static Alamat CreateAlamat(string jalan, string kelurahan, string kecamatan, string kota, string propinsi, string kodePos, string noTelepon, string noFax, string noHandphone)
        {
            return new Alamat(jalan, kelurahan, kecamatan, kota, propinsi, kodePos, noTelepon, noFax, noHandphone);
        }




    }
}
