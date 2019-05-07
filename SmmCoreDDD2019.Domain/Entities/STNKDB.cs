using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SmmCoreDDD2019.Domain.Entities
{
    public class STNKDB
    {
        public int NoUrutStnk { get; set; }
        [Display(Name = "Tanggal Pembayaran STNK"), Required]
        public DateTime? TanggalBayarSTNK { get; set; }
        [Display(Name = "Nama Faktur")]
        public int? NoUrutFaktur { get; set; }
        [Display(Name = "No STNK")]
        public string NoStnk { get; set; }
        [Display(Name = "Pajak STNK")]
        public decimal PajakStnk { get; set; }
        [Display(Name = "Birojasa")]
        public decimal Birojasa { get; set; }
        [Display(Name = "Biaya Tambahan")]
        public decimal BiayaTambahan { get; set; }
        [Display(Name = "Form A")]
        public decimal FormA { get; set; }
        [Display(Name = "No Polisi")]
        public string NomorPlat { get; set; }
        [Display(Name = "Perwil")]
        public decimal? Perwil { get; set; }
        [Display(Name = "Pajak Progresif")]
        public decimal? PajakProgresif { get; set; }
        [Display(Name = "BBN Pabrik")]
        public decimal? BbnPabrik { get; set; }
        [Display(Name = "Progresif Ke")]
        public int? ProgresifKe { get; set; }
    }
}
