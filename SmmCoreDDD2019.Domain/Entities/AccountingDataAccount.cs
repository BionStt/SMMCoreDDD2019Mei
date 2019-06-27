using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Domain.Entities
{
    public class AccountingDataAccount : BaseEntity
    {
      //  public  int NoUrutAccountId { get; set; }
        public int? Lft { get; set; }
        public int? Rgt { get; set; }
        public string Parent { get; set; }
        public int? Depth { get; set; }
        public string KodeAccount { get; set; }
        public string Account { get; set; }
        public int? NormalPos { get; set; }
        public string Kelompok { get; set; }
        public string MataUangID { get; set; }
    }
}
