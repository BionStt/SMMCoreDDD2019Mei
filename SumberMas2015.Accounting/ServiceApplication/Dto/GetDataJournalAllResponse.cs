using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Accounting.ServiceApplication.Dto
{
    public class GetDataJournalAllResponse
    {
        public Guid AccountingDataAccountId { get; set; }
        public Guid AccountingDataJournalIdH { get; set; }

        public string DataAkun { get; set; }
        public decimal? Debit1 { get; set; }
        public decimal? Kredit1 { get; set; }
        public string Ket1 { get; set; }
        public DateTime TanggalInput { get; set; }
        public string NoBuktiJurnal { get; set; }

    }
}
