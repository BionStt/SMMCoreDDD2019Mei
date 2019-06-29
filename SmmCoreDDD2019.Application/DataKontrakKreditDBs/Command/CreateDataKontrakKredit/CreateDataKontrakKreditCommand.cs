using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using System.ComponentModel.DataAnnotations;
namespace SmmCoreDDD2019.Application.DataKontrakKreditDBs.Command.CreateDataKontrakKredit
{
    public class CreateDataKontrakKreditCommand:IRequest
    {
        public int NoUrutDataKontrakKredit { get; set; }
        //[Display(Name = "No Register Kontrak Kredit")]
        //public string NoRegisterKontrakKredit { get; set; }
        [Display(Name = "No Register Survei")]
        public int NoRegisterSurvei { get; set; }
        [Display(Name = "Tanggal Kontrak"), DataType(DataType.Text)]
        public DateTime? TanggalKontrak { get; set; }
        [Display(Name = "Pola Angsuran")]
        public string PolaAngsuran { get; set; }
        [Display(Name = "Cara Bayar")]
        public string CaraBayar { get; set; }
        [Display(Name = "Harga Barang")]
        public double? HargaBarang { get; set; }
        [Display(Name = "Uang Muka")]
        public double? UangMuka { get; set; }
        [Display(Name = "Asuransi")]
        public double? Asuransi { get; set; }
        [Display(Name = "Administrasi")]
        public double? Administrasi { get; set; }
        [Display(Name = "Bunga Efektif")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public decimal? BungaEff { get; set; }
        [Display(Name = "Bunga Flat")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public decimal? BungaFlat { get; set; }
        [Display(Name = "Tenor")]
        public int? LamaKredit { get; set; }
        [Display(Name = "Tanggal Jatuh Tempo")]
        public string TanggalAngsuranBulanan { get; set; }
        [Display(Name = "Angsuran Di Muka ?")]
        public string AngsuranDimuka { get; set; }
        [Display(Name = "Pinjaman Pokok")]
        public double? PinjamanPokok { get; set; }
        [Display(Name = "Nilai Bunga")]
        public double? NilaiBunga { get; set; }
        [Display(Name = "Nilai Kontrak")]
        public double? NilaiKontrak { get; set; }
        [Display(Name = "Angsuran Bulanan")]
        public double? AngsuranBulanan { get; set; }
        [Display(Name = "Biaya Administrasi Angsuran")]
        public double? BiayaAdministrasiAngsuran { get; set; }
        [Display(Name = "Penagih ID")]
        public string PenagihId { get; set; }
    }
}
