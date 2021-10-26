using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.DataSPK.Commands.CreateDataSPKKredit
{
    public class CreateDataSPKKreditCommand:IRequest<Guid>
    {
        public decimal BiayaAdministrasiKredit { get; set; }
        public decimal BiayaAdministrasiTunai { get; set; }
        public decimal BBN { get; set; }
        public decimal DendaWilayah { get; set; }
        public decimal  DiskonDP{ get; set; }
        public decimal DiskonTunai { get; set; }
        public decimal DPPriceList { get; set; }
        public decimal Komisi { get; set; }
        public decimal OffTheRoad { get; set; }
        public decimal Promosi { get; set; }
        public decimal UangTandaJadiTunai{ get; set; }
        public int DataSPKId { get; set; }

    }
}
