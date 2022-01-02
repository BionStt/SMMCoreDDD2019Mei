using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.ServiceApplication.StokUnit.Commands.StokUnitSold
{
    public class StokUnitSoldCommand:IRequest
    {
        public Guid StokUnitId { get; set; }
    }
}
