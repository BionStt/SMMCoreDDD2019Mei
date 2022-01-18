using MediatR;
using SumberMas2015.Blazor.Shared.Dto.MasterBidangUsaha;
//using SumberMas2015.SalesMarketing.Dto.MasterBidangUsahaDBs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.MasterBidangUsahaDBs.Queries
{
    public class GetNamaBidangUsahaQuery : IRequest<IReadOnlyCollection<GetNamaBidangUsahaResponse>>
    {

    }
}
