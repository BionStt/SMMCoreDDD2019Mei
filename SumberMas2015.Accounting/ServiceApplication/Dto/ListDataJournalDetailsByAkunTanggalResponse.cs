using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Accounting.ServiceApplication.Dto
{
    public class ListDataJournalDetailsByAkunTanggalResponse
    {
        public int NoUrutId { get; set; }
        public int NoIdBUkti { get; set; }
        public string KodeNamaAkun { get; set; }
        public decimal? Debit1 { get; set; }
        public decimal? Kredit1 { get; set; }
        public string Keterangan { get; set; }
        public DateTime TanggalInput { get; set; }
        public string NoBuktiJurnal { get; set; }

    }
}
