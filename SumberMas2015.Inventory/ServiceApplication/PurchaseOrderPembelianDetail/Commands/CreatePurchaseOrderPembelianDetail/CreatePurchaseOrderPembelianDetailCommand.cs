using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.ServiceApplication.PurchaseOrderPembelianDetail.Commands.CreatePurchaseOrderPembelianDetail
{
    public class CreatePurchaseOrderPembelianDetailCommand : IRequest<Guid>
    {
        public decimal? OffTHeRoad { get;  set; }
        public decimal? BBN { get;  set; }
        public decimal? Diskon { get;  set; }
        public string Warna { get;  set; }
        public int? Qty { get;  set; }
        public string Keterangan { get;  set; }
        public string UserName { get; set; }
        public Guid UserNameId { get; set; }
    }
}
