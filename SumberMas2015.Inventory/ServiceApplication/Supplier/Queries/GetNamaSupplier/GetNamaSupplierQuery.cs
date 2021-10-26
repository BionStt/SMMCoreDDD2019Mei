using MediatR;
using SumberMas2015.Inventory.Dto.Supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.ServiceApplication.Supplier.Queries.GetNamaSupplier
{
    public class GetNamaSupplierQuery:IRequest<IReadOnlyCollection<GetNamaSupplierResponse>>
    {

    }
}
