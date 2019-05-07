using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
namespace SmmCoreDDD2019.Application.CustomerDBs.Queries.GetCustomerDBList
{
    public class GetCustomersListQuery : IRequest<CustomersListViewModel>
    {
    }
}
