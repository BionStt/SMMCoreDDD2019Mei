using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.DataPenjualan.Commands.CreateDataPenjualanDetail
{
    public class CreateDataPenjualanDetailCommand : IRequest<Guid>
    {
        public Guid dataPenjualanId{get;set;}
        public Guid stokUnitId { get; set; }
        public decimal offTheRoad { get; set; }
        public decimal bBN { get; set; }
        public decimal hargaOTR { get; set; }
        public decimal uangMuka { get; set; }
        public decimal diskonKredit { get; set; }
        public decimal diskonTunai { get; set; }
        public decimal subsidi { get; set; }
        public decimal promosi { get; set; }
        public decimal komisi { get; set; }
        public decimal joinPromo1 { get; set; }
        public decimal joinPromo2 { get; set; }
        public decimal sPF { get; set; }
        public decimal sellOut { get; set; }
        public  decimal dendaWilayah { get; set; }
    }
}
