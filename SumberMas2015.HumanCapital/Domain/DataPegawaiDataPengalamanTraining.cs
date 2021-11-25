using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.HumanCapital.Domain
{
    public class DataPegawaiDataPengalamanTraining
    {
        public Guid DataPegawaiDataPengalamanTrainingId { get; private set; }
        public DateTime TanggalMengikutiTraining { get; private set; }
        public string NamaTraining { get; private set; }
        public string VendorTraining { get; private set; }

        public int NoUrutId { get; set; }
    }
}
