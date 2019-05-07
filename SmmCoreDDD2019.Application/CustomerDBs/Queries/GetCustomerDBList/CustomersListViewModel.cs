using System;
using System.Collections.Generic;
using System.Text;

namespace SmmCoreDDD2019.Application.CustomerDBs.Queries.GetCustomerDBList
{
    public class CustomersListViewModel
    {
        public IList<CustomerLookupModel> Customers { get; set; }
    }
}
