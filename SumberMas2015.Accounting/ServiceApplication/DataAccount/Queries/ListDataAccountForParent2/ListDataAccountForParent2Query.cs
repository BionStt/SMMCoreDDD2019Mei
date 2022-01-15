using MediatR;
using SumberMas2015.Accounting.ServiceApplication.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Accounting.ServiceApplication.DataAccount.Queries.ListDataAccountForParent2
{
    public class ListDataAccountForParent2Query : IRequest<IReadOnlyCollection<ListDataAccountForParent2QueryResponse>>
    {
        public int Data1 { get; set; }

    }
}
