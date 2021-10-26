using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.Inventory.Dto.Supplier;
using SumberMas2015.Inventory.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.ServiceApplication.Supplier.Queries.GetNamaSupplier
{
    public class GetNamaSupplierQueryHandler : IRequestHandler<GetNamaSupplierQuery, IReadOnlyCollection<GetNamaSupplierResponse>>
    {
        private readonly InventoryContext _context;

        public GetNamaSupplierQueryHandler(InventoryContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyCollection<GetNamaSupplierResponse>> Handle(GetNamaSupplierQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _context.Supplier.Select(x=> new GetNamaSupplierResponse {
            NamaSupplier = x.NamaSupplier,
            NoUrutSupplier = x.NoUrutId

            }).AsNoTracking().ToListAsync();

                return returnQuery;

        }
    }
}
