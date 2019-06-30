using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Domain.Entities
{
    public class AccountingDataSaldoAwal : BaseEntity
    {
      //  public int NoUrutSaldoAwalID { get; set; }
        public int AccountingDataPeriodeId { get; set; }
        public int AccountingDataAccountId { get; set; }

        public Decimal Debet { get; set; }

        public Decimal Kredit { get; set; }
        public Decimal Saldo { get; set; }

        public int? AccountingDataMataUangId { get; set; }

        public string UserInput { get; set; }
        public Decimal NilaiKurs{ get; set; }
        public DateTime TanggalInput { get; set; }


    }
}
