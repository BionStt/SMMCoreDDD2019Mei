using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Organization.Domain
{
    public class DataKamusKompetensiIndikatorPerilaku
    {
        public Guid DataKamusKompetensiIndikatorPerilakuId { get; set; }
        public Guid DataKamusKompetensiLevelingId { get; set; }
        public int NoUrutId { get; set; }
        public string IndikatorPerilaku { get; set; }

        public string Pelatihan { get; set; }
    }
}
