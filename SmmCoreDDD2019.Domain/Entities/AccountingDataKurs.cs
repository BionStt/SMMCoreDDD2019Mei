using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Domain.Entities
{
    public class AccountingDataKurs : BaseEntity
    {
       // public int NoUrutKursID { get; set; }
        public string MataUangID { get; set; }
        public DateTime TanggalInput { get; set; }
        public decimal Nilai { get; set; }
    }
}
