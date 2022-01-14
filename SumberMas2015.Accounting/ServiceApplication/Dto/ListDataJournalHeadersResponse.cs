using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Accounting.ServiceApplication.Dto
{
    public class ListDataJournalHeadersResponse
    {
        public Guid DataJournalHeadersId { get; set; }

        public int NoUrutId { get; set; }
        public DateTime TanggalInput { get; set; }
        public string NoBuktiJournal { get; set; }
        public string Keterangan { get; set; }
        public string UserInput { get; set; }
        public decimal TotalRupiah { get; set; }
        public string ValidasiOleh { get; set; }



    }
}
