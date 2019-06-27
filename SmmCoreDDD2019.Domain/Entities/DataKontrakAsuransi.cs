using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Domain.Entities
{
    public class DataKontrakAsuransi : BaseEntity
    {
       // public int NoUrutDataAsuransi { get; set; }
        public string NoRegistrasiKontrakKredit { get; set; }
        public string NoRegistrasiKontrakAsuransi { get; set; }
        public string KodeAsuransi { get; set; }
        public int? JenisAsuransi { get; set; }
        public DateTime? TanggalMulaiAsuransi { get; set; }
        public DateTime? TanggalAkhirAsuransi { get; set; }
        public int? LamaAsuransi { get; set; }
        public decimal? NilaiPertanggungan { get; set; }
        public decimal? BiayaAsuransi { get; set; }
    }
}
