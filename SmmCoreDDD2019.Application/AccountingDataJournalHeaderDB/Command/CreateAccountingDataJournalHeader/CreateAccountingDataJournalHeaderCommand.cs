using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace SmmCoreDDD2019.Application.AccountingDataJournalHeaderDB.Command.CreateAccountingDataJournalHeader
{
    public class CreateAccountingDataJournalHeaderCommand : IRequest
    {
        //  public int NoUrutJournalH { get; set; }
        [Display(Name = "Periode Pembukuan")]
        public int NoUrutPeriodeID { get; set; }
        [Display(Name = "Tanggal Input Journal")]
        public DateTime TangglInput { get; set; }
        [Display(Name = "No Bukti Journal")]
        public string NoBuktiJournal { get; set; }
        [Display(Name = "Keterangan")]
        public string Keterangan { get; set; }
        [Display(Name = "Tipe Journal")]
        public int NoIDTipeJournal { get; set; }
      

        public string UserInput { get; set; }
      
      //  public DateTime Validasi { get; set; }
    
       // public string ValidasiOleh { get; set; }
       // public string Aktif { get; set; }
    }
}
