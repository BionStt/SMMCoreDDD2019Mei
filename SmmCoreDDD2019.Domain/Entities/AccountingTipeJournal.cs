using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Domain.Entities
{
    public class AccountingTipeJournal : BaseEntity
    {
       // public int NoIDTipeJournal { get; set; }
        public string KodeJournal { get; set; }
        public string NamaJournal { get; set; }

        public AccountingDataJournalHeader AccountingDataJournalHeader { get; set; }
        public AccountingDataBuktiTransaksi AccountingDataBuktiTransaksi { get; set; }


    }
}
