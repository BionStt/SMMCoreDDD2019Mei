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

namespace SumberMas2015.Inventory.ServiceApplication.PembelianDetail.Queries.GetListPembelianDetail
{
    public class GetListPembelianDetailQueryHandler : IRequestHandler<GetListPembelianDetailQuery, IReadOnlyCollection<GetListPembelianDetailResponse>>
    {
        private readonly InventoryContext _context;

        public GetListPembelianDetailQueryHandler(InventoryContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyCollection<GetListPembelianDetailResponse>> Handle(GetListPembelianDetailQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await (from a in _context.Pembelian
                                     join b in _context.PembelianDetail on a.PembelianId equals b.PembelianId
                                     join c in _context.MasterBarang on b.MasterBarangDBId equals c.MasterBarangId
                                     where a.NoUrutId ==int.Parse(request.Id)
                                     select new GetListPembelianDetailResponse {
                                         NoUrutPembelianDetail = b.NoUrutId,
                                         NamaBarang1 = c.NamaBarang,
                                         HargaOff = String.Format("{0:c}", c.HargaOff),
                                         BBN1 = String.Format("{0:c}", c.Bbn),
                                         HargaOTr = String.Format("{0:c}",c.HargaOff+c.Bbn),
                                         Diskon = String.Format("{0:c}",b.Diskon),
                                         SellIn = String.Format("{0:c}", b.SellIn),
                                         Qty1 = b.Qty
                                          //   Count1 = _context.StokUnit.Count(x => x.PembelianDetailId == b.Id)


                                     }).AsNoTracking().ToListAsync();

            return returnQuery;
        }
    }
}
