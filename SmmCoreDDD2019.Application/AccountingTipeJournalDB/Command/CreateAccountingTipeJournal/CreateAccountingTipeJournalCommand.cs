using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Exceptions;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;
using System.ComponentModel.DataAnnotations;
namespace SmmCoreDDD2019.Application.AccountingTipeJournalDB.Command.CreateAccountingTipeJournal
{
    public class CreateAccountingTipeJournalCommand : IRequest
    {
        public int NoIDTipeJournal { get; set; }
        [Display(Name = "Kode Journal")]
        public string KodeJournal { get; set; }
        [Display(Name = "Nama Journal")]
        public string NamaJournal { get; set; }
    }
}
