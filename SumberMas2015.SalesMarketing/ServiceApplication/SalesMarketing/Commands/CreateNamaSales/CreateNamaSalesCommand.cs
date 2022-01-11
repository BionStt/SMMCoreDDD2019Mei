using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.SalesMarketing.Commands.CreateNamaSales
{
    public class CreateNamaSalesCommand : IRequest
    {
        public Guid DataSalesMarketingId { get;  set; }
        public string NamaSales { get;  set; }
    }
}
