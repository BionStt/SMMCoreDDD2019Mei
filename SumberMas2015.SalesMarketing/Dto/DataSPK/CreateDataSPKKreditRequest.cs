using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Dto.DataSPK
{
    public class CreateDataSPKKreditRequest
    {
        public decimal BiayaAdministrasiKredit { get;  set; }
        public decimal BiayaAdministrasiTunai { get;  set; }
        public decimal BBN { get;  set; }
        public decimal DendaWilayah { get;  set; }
        public decimal DiskonDP { get; set; }
        public decimal DiskonTunai { get;  set; }
        public decimal DPPriceList { get;  set; }
        public decimal Komisi { get;  set; }
        public decimal Promosi { get;  set; }
        public decimal UangTandaJadiTunai { get;  set; }
        public decimal UangTandaJadiKredit { get;  set; }
        public decimal OffTheRoad { get;  set; }
        public int DataSPKId { get;  set; }

        public string UserName { get; set; }
        public Guid UserNameId { get; set; }

    }
}
