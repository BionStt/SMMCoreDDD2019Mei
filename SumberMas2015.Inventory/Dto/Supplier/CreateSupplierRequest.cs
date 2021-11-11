using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.Dto
{
    public class CreateSupplierRequest
    {
        public string NamaSupplier { get;  set; }
        public string Email { get;  set; }
        public string Jalan { get; set; }
        public string Kelurahan{ get; set; }
        public string Kecamatan { get; set; }
        public string Kota{ get; set; }

        public string Propinsi{ get; set; }
        public string KodePos { get; set; }
        public string NomorTelepon{ get; set; }
        public string NomorFaks { get; set; }
        public string NomorHandphone{ get; set; }
        public Guid UserNameInput { get; set; }

    }
}
