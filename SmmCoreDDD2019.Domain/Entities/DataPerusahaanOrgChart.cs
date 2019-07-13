using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Domain.Entities
{
    public class DataPerusahaanOrgChart:BaseEntity
    {
        // public int NoUrutStrukturID { get; set; }
        public int? Lft { get; set; }
        public int? Rgt { get; set; }
        public string Parent { get; set; }
        public int? Depth { get; set; }
        public string KodeStrukturJabatan { get; set; }
        public string NamaStrukturJabatan { get; set; }
    }
}
