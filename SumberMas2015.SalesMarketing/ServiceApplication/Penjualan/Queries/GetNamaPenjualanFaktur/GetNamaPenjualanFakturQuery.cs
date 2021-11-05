using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SumberMas2015.SalesMarketing.Dto.Penjualan;

namespace SumberMas2015.SalesMarketing.ServiceApplication.Penjualan.Queries.GetNamaPenjualanFaktur
{
    public class GetNamaPenjualanFakturQuery:IRequest<IReadOnlyCollection<GetNamaPenjualanFakturResponse>>
    {
     
    }
}
