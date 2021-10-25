using MediatR;
using SumberMas2015.SalesMarketing.Dto.Agama;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.Agama.Queries.AgamaListById
{
    public class AgamaListByIdQuery:IRequest<AgamaListByIdResponse>
    {
        public int AgamaId { get; set; }
    }
}
