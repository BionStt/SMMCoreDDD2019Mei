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

namespace SumberMas2015.Inventory.ServiceApplication.PembelianDetail.Queries.GetKodeBeli
{
    public class GetKodeBeliQueryHandler : IRequestHandler<GetKodeBeliQuery, IReadOnlyCollection<GetKodeBeliResponse>>
    {
        private readonly InventoryContext _context;

        public GetKodeBeliQueryHandler(InventoryContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyCollection<GetKodeBeliResponse>> Handle(GetKodeBeliQuery request, CancellationToken cancellationToken)
        {
            var returnQuery =await( from a in _context.Pembelian
                                    join b in _context.Supplier on a.SupplierId equals b.SupplierId
                                    select new GetKodeBeliResponse {
                                    NoUrutPembelian = a.NoUrutId,
                                    NamaPembelian = string.Format("{0}  - {1:d} - {2}", a.NoUrutId, a.TanggalBeli, b.NamaSupplier)}

                                    ).OrderByDescending(x => x.NoUrutPembelian).AsNoTracking().ToListAsync();

            return returnQuery;
        }
    }
}
