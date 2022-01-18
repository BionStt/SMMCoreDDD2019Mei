using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Blazor.Shared.Dto.MasterBarang
{
    public class CreateMasterBarangRequest
    {
        public string NamaBarang { get; set; }
        public string NomorRangka { get; set; }
        public string NomorMesin { get; set; }
        public string Merek { get; set; }
        public string KapasitasMesin { get; set; }
        public decimal HargaOff { get; set; }
        public decimal BBn { get; set; }
        public string TahunPerakitan { get; set; }
        public string TypeKendaraan { get; set; }
        public string UserName { get; set; }
        public string UserId { get; set; }
    }
}
