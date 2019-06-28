using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Domain.Entities
{
    public class MasterPerusahaanAsuransi : BaseEntity
    {
      //  public int NoUrutPerusahaanAsuransi { get; set; }
        public string KodeAsuransi { get; set; }
        public string NamaAsuransi { get; set; }
        public string AlamatAsuransi { get; set; }
        public string KelurahanAsuransi { get; set; }
        public string KecamatanAsuransi { get; set; }
        public string KotaAsuransi { get; set; }
        public string PropinsiAsuransi { get; set; }
        public string KodePosAsuransi { get; set; }
        public string TelpAsuransi { get; set; }
        public string FaxAsuransi { get; set; }
        public string PihakBerwenang { get; set; }

        public DataKontrakAsuransi DataKontrakAsuransi { get; set; }
    }
}
