
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Domain.EnumInEntity
{
    public class Agama
    {
        public Guid AgamaId { get; set; }
        private Agama(string agamaKeterangan)
        {
            AgamaId = Guid.NewGuid();
            AgamaKeterangan = agamaKeterangan;
        }

        public static Agama AddAgama(string agamaKeterangan)
        {
            return new Agama(agamaKeterangan);
        }
        public String AgamaKeterangan { get; set; }
        public int NoUrutId { get; set; }

    }
}
