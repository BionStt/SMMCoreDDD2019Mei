using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Domain.Entities
{
    public class AccountingDataPeriode
    {
        public int NoUrutPeriodeID { get; set; }
        public DateTime Mulai { get; set; }
        public DateTime Berakhir { get; set; }
        public string IsAktif { get; set; }
        public string UserInput {get;set;}
    }
}
