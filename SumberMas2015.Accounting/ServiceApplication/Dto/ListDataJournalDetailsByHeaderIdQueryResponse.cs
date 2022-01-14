using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Accounting.ServiceApplication.Dto
{
    public class ListDataJournalDetailsByHeaderIdQueryResponse
    {
        public int NourutID { get; set; }

        public Guid KodeJournalHeaderId { get; set; }
        public string KodeNamaAkun { get; set; }
        public decimal? Debit1 { get; set; }
        public decimal? Kredit1 { get; set; }
        public string Ket1 { get; set; }

    }
}
