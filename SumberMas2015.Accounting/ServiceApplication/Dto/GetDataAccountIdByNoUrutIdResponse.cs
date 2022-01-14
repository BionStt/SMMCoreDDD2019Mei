using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Accounting.ServiceApplication.Dto
{
    public class GetDataAccountIdByNoUrutIdResponse
    {
        public int NoUrutId { get; set; }
        public Guid DataAccountId { get; set; }

    }
}
