using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SumberMas2015.SalesMarketing.Dto.PermohonanSTNK;

namespace SumberMas2015.SalesMarketing.ServiceApplication.PermohonanSTNK.Queries.GetNamaFakturStnk
{
    public class GetNamaFakturStnkQuery : IRequest<IReadOnlyCollection<GetNamaFakturStnkResponse>>
    {
        
    }
}
