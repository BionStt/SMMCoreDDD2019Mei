using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.MasterLeasing.Commands.CreateMasterLeasing
{
    public class CreateMasterLeasingCommand:IRequest<Guid>
    {
        public string NamaLeasing { get; set; }
    }
}
