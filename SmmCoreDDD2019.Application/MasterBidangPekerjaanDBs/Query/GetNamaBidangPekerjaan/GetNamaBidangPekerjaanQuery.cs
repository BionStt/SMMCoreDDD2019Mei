using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Dto.MasterBidangPekerjaanDBs;

namespace SmmCoreDDD2019.Application.MasterBidangPekerjaanDBs.Query.GetNamaBidangPekerjaan
{
    public class GetNamaBidangPekerjaanQuery : IRequest<IReadOnlyCollection<GetNamaBidangPekerjaanResponse>>
    {

    }
}
