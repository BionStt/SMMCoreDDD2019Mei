using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Accounting.ServiceApplication.Dto
{
    public class GetLaporanLabaRugiResponse
    {
        public string NamaAkun { get; set; }
        public string KodeAccountParent { get; set; }
        public string AccountParent { get; set; }
        public string KodeAccountParent1 { get; set; }
        public string AccountParent1 { get; set; }
        public string KodeAccount1 { get; set; }
        public string Account1a { get; set; }
        public decimal Debit1 { get; set; }
        public decimal Kredit1 { get; set; }
        public decimal? Saldo1 { get; set; }
        public int? depth1 { get; set; }
        public string KodeAkunInduk { get; set; }
        public int? normalPosInduk { get; set; }

    }
}
