using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Domain.Entities
{
    public class AccountingDataJournal : BaseEntity
    {
          //  public int JournalID { get; set; }
            public int AccountingDataJournalHeaderId { get;set;}
              public string NoUrutAccountId { get;set;}
            public Decimal? Debit {get;set;}
           public Decimal? Kredit {get;set;}
           public string Keterangan  {get;set;}
     



    }
}
