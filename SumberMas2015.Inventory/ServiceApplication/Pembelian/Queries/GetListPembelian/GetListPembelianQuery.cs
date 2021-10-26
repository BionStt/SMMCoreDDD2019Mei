using MediatR;
using SumberMas2015.Inventory.Dto.Pembelian;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.ServiceApplication.Pembelian.Queries.GetListPembelian
{
    public class GetListPembelianQuery:IRequest<IReadOnlyCollection<GetListPembelianResponse>>
    {

    }
}
