using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace SmmCoreDDD2019.Application.AccountingDataJournalDB.Command.CreateAccountingDataJournal
{
    public class CreateAccountingDataJournalCommand : IRequest
    {
     
        //  public int JournalID { get; set; }
        [Display(Name = "Journal Header")]
        public int AccountingDataJournalHeaderId { get; set; }
        [Display(Name = "Nama Akun")]
        public int AccountingDataAccountId { get; set; }
        [Display(Name = "Debit")]
        public Decimal Debit { get; set; }
        [Display(Name = "Kredit")]
        public Decimal Kredit { get; set; }
        [Display(Name = "Keterangan")]
        public string Keterangan { get; set; }
    }
}
