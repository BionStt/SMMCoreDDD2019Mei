using MediatR;
using SumberMas2015.SalesMarketing.Dto.SalesMarketing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.SalesMarketing.Queries.GetNamaSalesForce
{
    public class GetNamaSalesForceQuery:IRequest<IReadOnlyCollection<GetNamaSalesForceResponse>>
    {
        
    }
}
