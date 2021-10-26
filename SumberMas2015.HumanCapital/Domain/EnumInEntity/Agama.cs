using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.HumanCapital.Domain.EnumInEntity
{
    public class Agama
    {
        protected Agama()
        {

        }
        private Agama(string agamaKeterangan)
        {
            Id = Guid.NewGuid();
            AgamaKeterangan = agamaKeterangan;
        }

        public static Agama AddAgama(string agamaKeterangan)
        {
            return new Agama(agamaKeterangan);
        }
        public String AgamaKeterangan { get; set; }
        public Guid Id { get; set; }
        public int NoUrutId { get; set; }


        //   public List<DataKonsumen> DataKonsumen { get; set; }

    }
}
