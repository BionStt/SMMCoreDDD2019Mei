using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Accounting.ServiceApplication.Dto
{
    public class CreateDataJournalsRequest
    {
        //public string NoBuktiJournal { get; set; }
        public string Keterangan { get; set; }
        public int TipeJournalId { get; set; }
        public string UserInput { get; set; }
        public decimal TotalRupiah { get; set; }
        public DateTime TanggalInput { get; set; }

    }
}
