using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.ServiceApplication.PembelianDetail.Commands.CreatePembelianDetail
{
    public class CreatePembelianDetailCommand : IRequest<Guid>
    {
        public decimal? HargaOffTheRoad { get;  set; }
        public decimal? BBN { get;  set; }
        //public decimal? Sellin2 { get;  set; }
        //public decimal? Diskon2 { get;  set; }
        //public decimal? Harga1 { get;  set; }
        public decimal? SellIn { get;  set; }
        public decimal? Diskon { get;  set; }
        public int Qty { get;  set; }
        //public decimal? HargaPPN { get;  set; }
        //public decimal? DiskonPPN { get;  set; }
        //public decimal? SellInPPN { get;  set; }
        public int MasterBarangId { get; set; }
        public int PembelianId { get; set; }
    }
}
