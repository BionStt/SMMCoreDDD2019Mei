using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Accounting.Domain
{
    public class DataSaldoAwal
    {
        public Guid DataSaldoAwalId { get; set; }

        public int NoUrutId { get; set; }


        public Guid DataAccountId { get; set; }

        public Decimal Debet { get; set; }

        public Decimal Kredit { get; set; }
        public Decimal Saldo { get; set; }

        public DateTime TanggalInput { get; set; }


    }
}
