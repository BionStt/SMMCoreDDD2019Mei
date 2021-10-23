using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Dto.MasterBidangUsahaDBs;

namespace SmmCoreDDD2019.Application.MasterBidangUsahaDBs.Query.GetNamaBidangUsaha
{
    public class GetNamaBidangUsahaQuery : IRequest<IReadOnlyCollection< GetNamaBidangUsahaResponse>>
    {

    }
}
