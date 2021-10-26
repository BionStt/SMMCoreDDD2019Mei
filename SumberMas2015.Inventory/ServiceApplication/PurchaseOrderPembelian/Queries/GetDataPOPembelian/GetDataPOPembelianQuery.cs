using MediatR;
using SumberMas2015.Inventory.Dto.PurchaseOrderPembelian;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.ServiceApplication.PurchaseOrderPembelian.Queries.GetDataPOPembelian
{
    public class GetDataPOPembelianQuery:IRequest<IReadOnlyCollection<GetDataPOPembelianResponse>>
    {

    }
}
