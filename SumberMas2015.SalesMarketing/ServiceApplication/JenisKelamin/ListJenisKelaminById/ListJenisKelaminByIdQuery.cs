using MediatR;
using SumberMas2015.SalesMarketing.Dto.JenisKelamin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.JenisKelamin.ListJenisKelaminById
{
    public class ListJenisKelaminByIdQuery:IRequest<ListJenisKelaminByIdResponse>
    {
        public int NoUrutId { get; set; }
    }
}
