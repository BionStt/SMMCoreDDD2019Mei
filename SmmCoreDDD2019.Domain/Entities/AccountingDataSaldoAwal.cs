using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Domain.Entities
{
    public class AccountingDataSaldoAwal
    {
        public int NoUrutSaldoAwalID { get; set; }
        public string NoUrutPeriodeID { get; set; }
        public string NoUrutAccountId { get; set; }

        public Decimal Debet { get; set; }

        public Decimal Kredit { get; set; }
        public Decimal Saldo { get; set; }

        public string MataUangID { get; set; }

        public string UserInput { get; set; }
        public Decimal NilaiKurs{ get; set; }
        public DateTime TanggalInput { get; set; }
    }
}
