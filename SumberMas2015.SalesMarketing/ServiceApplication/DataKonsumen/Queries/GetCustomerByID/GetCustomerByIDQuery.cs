using MediatR;
using SumberMas2015.SalesMarketing.Dto.DataKonsumen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.DataKonsumen.Queries.GetCustomerByID
{
    public class GetCustomerByIDQuery : IRequest<GetCustomerByIDResponse>
    {
        public string Id { get; set; }
    }
}
