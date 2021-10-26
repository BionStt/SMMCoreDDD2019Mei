using MediatR;
using SumberMas2015.Inventory.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.ServiceApplication.StokUnit.Queries.GetDataSO
{
    public class GetDataSOQuery:IRequest<IReadOnlyCollection<GetDataSOResponse>>
    {

    }
}
