using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.DataSPK.Commands.CreateDataSPK
{
    public class CreateDataSPKCommand:IRequest<Guid>
    {
        public string NamaLokasi { get; set; }
        public DateTime? TanggalInput { get; set; }
        public string UserName { get; set; }
        public Guid UserNameId{ get; set; }

    }
}
