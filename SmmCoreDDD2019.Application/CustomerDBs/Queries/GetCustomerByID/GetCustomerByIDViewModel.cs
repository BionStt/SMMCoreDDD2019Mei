using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Application.CustomerDBs.Queries.GetCustomerByID
{
    public class GetCustomerByIDViewModel
    {
        public IEnumerable<GetCustomerByIDLookUpModel> CustomerDs { get; set; }
    }
}
