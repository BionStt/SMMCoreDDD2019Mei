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

namespace SumberMas2015.Inventory.ServiceApplication.PurchaseOrderPembelian.Queries.GetDataPOPembelian
{
    public class GetDataPOPembelianQueryHandler : IRequestHandler<GetDataPOPembelianQuery, IReadOnlyCollection<GetDataPOPembelianResponse>>
    {
        private readonly InventoryContext _context;

        public GetDataPOPembelianQueryHandler(InventoryContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyCollection<GetDataPOPembelianResponse>> Handle(GetDataPOPembelianQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _context.PurchaseOrderPembelian.Where(x=>x.Terinput == "0").Select(x=> new GetDataPOPembelianResponse {
                NoUrutPoPembelian = x.NoUrutId,
                NamaPOPembelian = x.NoRegistrasiPoPMB + " - " + x.Keterangan

            }).OrderByDescending(x=>x.NoUrutPoPembelian).AsNoTracking().Take(10).ToListAsync();



                return returnQuery;
        }
    }
}
