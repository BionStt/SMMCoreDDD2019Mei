using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Dto.DataSPK
{
    public class CreateDataSPKLeasingRequest
    {
        public int DataSPKId { get; set; }
        public int MasterLeasingId { get; set; }
        public int MasterKategoriPenjualan{ get; set; }
        public int MasterKategoriBayaran{ get; set; }
        public decimal Angsuran { get;  set; }
        public string Mediator { get;  set; }
        public int NamaSalesId { get; set; }
        public string NamaSales { get;  set; }
        public string NamaCMO { get;  set; }
        public int Tenor { get;  set; }
        public DateTime TanggalSurvei { get;  set; }
        public string UserName { get; set; }
        public Guid UserNameId { get; set; }
    }
}
