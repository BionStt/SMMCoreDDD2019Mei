using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using System.ComponentModel.DataAnnotations;


namespace SmmCoreDDD2019.Application.PermohonanFakturDBs.Command.CreatePermohonanFaktur
{
    public class CreatePermohonanFakturCommand:IRequest
    {
        //public DateTime? TanggalMohonFaktur { get; set; }
        [Display(Name = "Data Penjualan")]
        public int? KodePenjualanDetail { get; set; }
        [Display(Name = "Tanggal Lahir"),DataType(DataType.Text)]
        public DateTime? TanggalLahir { get; set; }
        [Display(Name = "Nomor KTP",Prompt ="Masukkan Nomor KTP dengan lengkap")]
        public string NomorKTP { get; set; }
        [Display(Name = "Nama Faktur")]
        public string NamaFaktur { get; set; }
        [Display(Name = "Alamat")]
        public string Alamat { get; set; }
        [Display(Name = "Kelurahan")]
        public string Kelurahan { get; set; }
        [Display(Name = "Kecamatan")]
        public string Kecamatan { get; set; }
        [Display(Name = "Kota")]
        public string Kota { get; set; }
        [Display(Name = "Propinsi")]
        public string Propinsi { get; set; }
        [Display(Name = "Kode Pos")]
        public string KodePos { get; set; }
        [Display(Name = "Telepon")]
        public string Telepon { get; set; }
        [Display(Name = "Handphone")]
        public string HandphoneF { get; set; }
    }
}
