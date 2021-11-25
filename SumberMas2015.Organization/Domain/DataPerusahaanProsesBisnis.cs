using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Organization.Domain
{
    public class DataPerusahaanProsesBisnis
    {
        public Guid DataProsesBisnisId { get; set; }

        public int? Lft { get; set; }
        public int? Rgt { get; set; }
        public string? Parent { get; set; }
        public int? Depth { get; set; }
        public string KodeProsesBisnis { get; set; }
        public string NamaProsesBisnis { get; set; }
        public bool Aktif { get; set; } = false;


        public int NoUrutId { get; set; }
    }
}
