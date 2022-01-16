using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.Inventory.Dto.PurchaseOrderPembelian;
using SumberMas2015.Inventory.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.ServiceApplication.PurchaseOrderPembelian.Queries.GetNamaPO
{
    public class GetNamaPOQueryHandler : IRequestHandler<GetNamaPOQuery, IReadOnlyCollection<GetNamaPOResponse>>
    {
        private readonly InventoryContext _context;

        public GetNamaPOQueryHandler(InventoryContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyCollection<GetNamaPOResponse>> Handle(GetNamaPOQuery request, CancellationToken cancellationToken)
        {
            var returnQuery= await (from a in _context.PurchaseOrderPembelian
                                    join b in _context.Supplier on a.MasterSupplierDBId equals b.SupplierId
                                    where a.Terinput =="0"
                                    select new GetNamaPOResponse {
                                    NoUrutPoPembelian = a.NoUrutId,
                                    NamaPOPembelian = String.Format("{0} - {1:d} - {2}", a.NoUrutId,a.TanggalPurchaseOrder,b.NamaSupplier)
                                    }

                ).OrderByDescending(x => x.NoUrutPoPembelian).AsNoTracking().ToListAsync();




            return returnQuery;
        }
    }
}
