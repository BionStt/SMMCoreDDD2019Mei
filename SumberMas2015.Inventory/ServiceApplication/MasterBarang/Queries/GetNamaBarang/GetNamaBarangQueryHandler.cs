using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.Inventory.Dto.MasterBarang;
using SumberMas2015.Inventory.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.ServiceApplication.MasterBarang.Queries.GetNamaBarang
{
    public class GetNamaBarangQueryHandler : IRequestHandler<GetNamaBarangQuery, IReadOnlyCollection<GetNamaBarangResponse>>
    {
        private readonly InventoryContext _context;

        public GetNamaBarangQueryHandler(InventoryContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyCollection<GetNamaBarangResponse>> Handle(GetNamaBarangQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _context.MasterBarang.Select(x => new GetNamaBarangResponse
            {
                NoUrutKendaraan = x.NoUrutId,
                NamaBarang = x.NamaBarang

            }).AsNoTracking().ToListAsync();

            return returnQuery;
        }
    }
}
