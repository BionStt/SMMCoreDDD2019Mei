using MediatR;
using SumberMas2015.SalesMarketing.Dto.MasterKategoriBayaran;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.MasterKategoriBayaran.Queries.ListKategoriBayaran
{
    public class ListKategoriBayaranQuery:IRequest<IReadOnlyCollection<ListKategoriBayaranResponse>>
    {

    }
}
