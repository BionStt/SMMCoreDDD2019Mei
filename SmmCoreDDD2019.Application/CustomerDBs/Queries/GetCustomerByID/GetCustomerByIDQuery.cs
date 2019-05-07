using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
namespace SmmCoreDDD2019.Application.CustomerDBs.Queries.GetCustomerByID
{
    public class GetCustomerByIDQuery : IRequest<GetCustomerByIDViewModel>
    {
        public string Id { get; set; }
    }
}
