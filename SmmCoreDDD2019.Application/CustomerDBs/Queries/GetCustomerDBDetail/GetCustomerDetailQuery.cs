using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace SmmCoreDDD2019.Application.CustomerDBs.Queries.GetCustomerDBDetail
{
    public class GetCustomerDetailQuery : IRequest<CustomerDetailModel>
    {
        public string Id { get; set; }
    }
}
