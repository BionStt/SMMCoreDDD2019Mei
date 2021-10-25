using MediatR;
using SumberMas2015.SalesMarketing.Dto.Agama;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.Agama.Queries.AgamaList
{
    public class AgamaListQuery:IRequest<IReadOnlyCollection<AgamaListResponse>>
    {

    }
}
