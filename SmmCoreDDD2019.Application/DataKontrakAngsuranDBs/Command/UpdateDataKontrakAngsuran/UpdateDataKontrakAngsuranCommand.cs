using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.DataKontrakAngsuranDBs.Command.UpdateDataKontrakAngsuran
{
    public class UpdateDataKontrakAngsuranCommand:IRequest
    {
        public int NoUrutDataAngsuran { get; set; }
        [Display(Name = "No Register Kontrak Kredit")]
        public int NoRegisterKontrakKredit { get; set; }
        [Display(Name = "Angsuran Ke")]
        public int? AngsuranKe { get; set; }
        [Display(Name = "No Kwitansi")]
        public string NoKwitansi { get; set; }
        [Display(Name = "Tanggal Jatuh Tempo ")]
        public DateTime? TanggalAngsuran { get; set; }
        [Display(Name = "Nilai Angsuran")]
        public double? Angsuran { get; set; }
        [Display(Name = "Pokok")]
        public double? Pokok { get; set; }
        [Display(Name = "Bunga")]
        public double? Bunga { get; set; }
        [Display(Name = "Sisa Pokok")]
        public double? SisaPokok { get; set; }
        [Display(Name = "Sisa Bunga")]
        public double? SisaBunga { get; set; }
        [Display(Name = "Denda")]
        public double? Denda { get; set; }
        [Display(Name = "Diskon Denda")]
        public double? DiskonDenda { get; set; }
        [Display(Name = "Titipan Angsuran")]
        public double? TitipanAngsuran { get; set; }
        [Display(Name = "@Tanggal Pembayaran")]
        public DateTime? TanggalBayarAngsuran { get; set; }
        [Display(Name = "Jumlah Pembayaran")]
        public double? JumlahPembayaran { get; set; }
        [Display(Name = "Cara Bayar")]
        public int? CaraBayar { get; set; }
        [Display(Name = "Biaya Administrasi")]
        public double? BiayaAdministrasi { get; set; }
        [Display(Name = "Penagih")]
        public string PenagihId { get; set; }
    }
}
