using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Accounting.ServiceApplication.Dto
{
    public class GetDataSaldoAwalResponse
    {
        public string Parent { get; set; }
        public string KodeAccount { get; set; }
        public string Account { get; set; }
        public int? NormalPos { get; set; }
        public string Kelompok { get; set; }
        public int? Depth { get; set; }
        public int NoUrutId { get; set; }
        public decimal Debit { get; set; }
        public decimal Kredit { get; set; }
    }
}
