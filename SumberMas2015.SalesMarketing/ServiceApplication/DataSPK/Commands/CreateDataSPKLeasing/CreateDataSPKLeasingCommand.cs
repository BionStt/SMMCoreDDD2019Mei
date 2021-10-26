using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.DataSPK.Commands.CreateDataSPKLeasing
{
    public class CreateDataSPKLeasingCommand:IRequest<Guid>
    {
        public decimal Angsuran { get; set; }
        public string Mediator{ get; set; }

        public string NamaSales { get; set; }
        public string NamaCMO { get; set; }
        public int Tenor { get; set; }
        public DateTime TanggalSurvei { get; set; }



    }
}
