using MediatR;
using SumberMas2015.Blazor.Shared.Dto.JenisKelamin;
//using SumberMas2015.SalesMarketing.Dto.JenisKelamin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.JenisKelamin.ListJenisKelamin
{
    public class ListJenisKelaminQuery :  IRequest<IReadOnlyCollection<ListJenisKelaminResponse>>
    {

    }
}
