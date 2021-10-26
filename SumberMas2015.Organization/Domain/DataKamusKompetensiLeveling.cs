using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Organization.Domain
{
    public class DataKamusKompetensiLeveling
    {
        public Guid DataKamusKompetensiLevelingId { get; set; }
        public Guid DataKamusKompetensiId { get; set; }
        public int NoUrutId { get; set; }
        public int Leveling { get; set; }
        public string PenjelasanLevel { get; set; }

    }
}
