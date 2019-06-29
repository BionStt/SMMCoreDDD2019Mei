using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.DataKontrakAsuransiDBs.Command.UpdateDataKontrakAsuransi
{
    public class UpdateDataKontrakAsuransiCommand:IRequest
    {
        public int NoUrutDataAsuransi { get; set; }
        [Display(Name = "No Registrasi Kontrak Kredit")]
        public int NoRegistrasiKontrakKredit { get; set; }
        [Display(Name = "Kode Asuransi")]
        public string KodeAsuransi { get; set; }
        [Display(Name = "Jenis Asuransi")]
        public int? JenisAsuransi { get; set; }
        [Display(Name = "Tanggal Mulai Asuransi")]
        public DateTime? TanggalMulaiAsuransi { get; set; }
        [Display(Name = "Tanggal Akhir Asuransi")]
        public DateTime? TanggalAkhirAsuransi { get; set; }
        [Display(Name = "Lama Asuransi")]
        public int? LamaAsuransi { get; set; }
        [Display(Name = "Nilai Pertanggungan")]
        public decimal? NilaiPertanggungan { get; set; }
        [Display(Name = "Biaya Asuransi")]
        public decimal? BiayaAsuransi { get; set; }
    }
}
