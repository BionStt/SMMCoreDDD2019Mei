using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.HumanCapital.Domain
{
    public class DataPegawaiDataLeaves
    {
        public Guid DataPegawaiDataLeavesId { get; set; }
        public Guid DatapegawaiId { get; set; }
        public DateTime TanggalMulai { get; set; }
        public DateTime TanggalBerakhir { get; set; }
        public int JumlahHari { get; set; }
    }
}
