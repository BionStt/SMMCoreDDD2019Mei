using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SumberMas2015.Organization.Dto.DataPerusahaan;

namespace SumberMas2015.Organization.ServiceApplication.DataPerusahaan.Queries.GetNamaPerusahaan
{
    public class GetNamaPerusahaanQuery:IRequest<IReadOnlyCollection<GetNamaPerusahaanResponse>>
    {
        
    }
}
