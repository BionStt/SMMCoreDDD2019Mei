using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Domain.Entities
{
    public class AccountingDataBuktiTransaksi
    {
        public int NoUrutBuktiTransaksi {get;set;}
        public string TipeJournal { get; set; }
        public string NoBukti { get; set; }
        public DateTime TanggalInput { get; set; }
        public string Keterangan { get; set; }
        public string ValidateBy { get; set; }
        public DateTime ValidatedDate { get; set;}
        public Decimal Total { get; set; }
    }
}
