using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace SmmCoreDDD2019.Application.CustomerDBs.Commands.DeleteCustomerDB
{
    public class DeleteCustomerCommand : IRequest
    {
        public string Id { get; set; }
    }
}
