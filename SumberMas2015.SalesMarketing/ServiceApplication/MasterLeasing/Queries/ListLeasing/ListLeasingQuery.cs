using MediatR;
using SumberMas2015.SalesMarketing.Dto.MasterLeasing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.MasterLeasing.Queries.ListLeasing
{
    public class ListLeasingQuery:IRequest<IReadOnlyCollection<ListLeasingResponse>>
    {
        
    }
}
