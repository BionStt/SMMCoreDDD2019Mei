using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.HumanCapital.Domain
{
    public class DataPegawaiDataBank
    {
        public Guid DataPegawaiDataBankId { get; set; }
        public int NoUrutId { get; set; }
        public string NamaRekening { get; set; }
        public string NomorRekening { get; set; }
        public string NamaBank { get; set; }
        public Guid DataPegawaiId { get; set; }
    }
}
