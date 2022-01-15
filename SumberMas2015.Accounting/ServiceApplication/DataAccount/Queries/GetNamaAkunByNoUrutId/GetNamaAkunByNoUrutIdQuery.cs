using MediatR;
using SumberMas2015.Accounting.ServiceApplication.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Accounting.ServiceApplication.DataAccount.Queries.GetNamaAkunByNoUrutId
{
    public class GetNamaAkunByNoUrutIdQuery : IRequest<GetNamaAkunByNoUrutIdResponse>
    {
        public string NoUrutId { get; set; }
    }
}
