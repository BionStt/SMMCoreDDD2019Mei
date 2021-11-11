using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.Dto.Penjualan
{
    public class CreateDataPenjualanDetailRequest
    {
        public  decimal BBN { get; set; }
        public decimal uangMuka { get;  set; }
        public decimal Subsidi { get;  set; }
        public int NoUrutSO { get;  set; }
        public decimal SPF { get;  set; }
        public decimal SellOut { get;  set; }
        public decimal promosi { get;  set; }
        public int KodePenjualan { get;  set; }
        public decimal DendaWilayah { get;  set; }
        public decimal DiskonKredit { get;  set; }
        public decimal DiskonTunai { get;  set; }
        public decimal HargaOTR { get;  set; }
        public decimal HargaOffTheRoad { get; set; }
        public decimal JoinPromo1 { get;  set; }
        public decimal JoinPromo2 { get;  set; }
        public decimal OffTheRoad { get;  set; }
        public decimal Komisi { get;  set; }
        public string UserName { get; set; }
        public Guid UserNameId { get; set; }
    }
}
