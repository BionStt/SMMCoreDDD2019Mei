using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.ServiceApplication.StokUnit.Commands.CreateStokUnit
{
    public class CreateStokUnitCreated : INotification
    {
        public Guid StokUnitId { get; set; }
        public Guid MasterBarangId { get; set; }
        public string NomorRangka { get; set; }
        public string NomorMesin { get; set; }
        public string NamaSupplier { get; set; }
    }
}
