using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.StokUnit.Commands.FromInventory
{
    public class CreateStokUnitCommand:IRequest
    {
        public Guid StokUnitId { get; set; }
        public Guid MasterBarangId { get; set; }
        public string NomorRangka { get; set; }
        public string NomorMesin { get; set; }
        public string NamaSupplier { get; set; }
    }
}
