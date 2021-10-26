using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Organization.Domain
{
    public class DataPerusahaanOrganisasiChart
    {
        public Guid DataPerusahaanOrganisasiChartId { get; set; }

        public int? Lft { get; set; }
        public int? Rgt { get; set; }
        public string Parent { get; set; }
        public int? Depth { get; set; }
        public string KodeStrukturJabatan { get; set; }
        public string NamaStrukturJabatan { get; set; }
        public string LokasiJabatan { get; set; }

        public int NoUrutId { get; set; }
    }
}
