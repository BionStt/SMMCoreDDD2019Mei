using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.Inventory.Dto.PembelianDetail;
using SumberMas2015.Inventory.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.ServiceApplication.PembelianDetail.Queries.GetKodeBeliDetail
{
    public class GetKodeBeliDetailQueryHandler : IRequestHandler<GetKodeBeliDetailQuery, GetKodeBeliDetailResponse>
    {
        private readonly InventoryContext _context;

        public GetKodeBeliDetailQueryHandler(InventoryContext context)
        {
            _context = context;
        }

        public async Task<GetKodeBeliDetailResponse> Handle(GetKodeBeliDetailQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await (from a in _context.PembelianDetail
                                     join b in _context.MasterBarang on a.MasterBarangDBId equals b.MasterBarangId
                                     join c in _context.Pembelian on a.PembelianId equals c.PembelianId
                                     join d in _context.Supplier on c.SupplierId equals d.SupplierId
                                     where a.NoUrutId == int.Parse(request.Id)
                                     select new GetKodeBeliDetailResponse {
                                         NoKodeBeli1 = c.NoUrutId,
                                         NoKodeBeliDetail = a.NoUrutId,
                                         KodeBarang = b.NoUrutId,
                                         HargaOff = b.HargaOff,
                                         Diskon1 = a.Diskon,
                                         SellIn1 = a.SellIn,
                                         NamaSupplier = d.NamaSupplier,
                                         NamaBarang1 = String.Format("{0} - {1} - {2}",b.TypeKendaraan,b.NamaBarang,b.Merek)

                                     }
                ).AsNoTracking().SingleOrDefaultAsync();


            return returnQuery;
        }
    }
}
