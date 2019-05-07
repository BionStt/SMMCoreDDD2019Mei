using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using System.ComponentModel.DataAnnotations;
namespace SmmCoreDDD2019.Application.MasterPerusahaanAsuransiDBs.Command.CreateMasterPerusahaanAsuransi
{
    public class CreateMasterPerusahaanAsuransiCommand:IRequest
    {
        [Display(Name = "Kode Asuransi")]
        public string KodeAsuransi { get; set; }
        [Display(Name = "Masukkan Nama Perusahaan ", Prompt = "Masukkan Nama Perusahaan Auransi dengan lengkap")]
        public string NamaAsuransi { get; set; }
        [Display(Name = "Alamat")]
        public string AlamatAsuransi { get; set; }
        [Display(Name = "Kelurahan ")]
        public string KelurahanAsuransi { get; set; }
        [Display(Name = "Kecamatan")]
        public string KecamatanAsuransi { get; set; }
        [Display(Name = "Kota")]
        public string KotaAsuransi { get; set; }
        [Display(Name = "Propinsi")]
        public string PropinsiAsuransi { get; set; }
        [Display(Name = "Kode Pos")]
        public string KodePosAsuransi { get; set; }
        [Display(Name = "Telepon")]
        public string TelpAsuransi { get; set; }
        [Display(Name = "Faks")]
        public string FaxAsuransi { get; set; }
        [Display(Name = "Pihak Bertanggung Jawab")]
        public string PihakBerwenang { get; set; }
    }
}
