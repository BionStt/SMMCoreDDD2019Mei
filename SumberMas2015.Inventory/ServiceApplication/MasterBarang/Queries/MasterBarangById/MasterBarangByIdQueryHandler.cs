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

namespace SumberMas2015.Inventory.ServiceApplication.MasterBarang.Queries.MasterBarangById
{
    public class MasterBarangByIdQueryHandler : IRequestHandler<MasterBarangByIdQuery, MasterBarangByIdResponse>
    {
        private readonly InventoryContext _context;

        public MasterBarangByIdQueryHandler(InventoryContext context)
        {
            _context = context;
        }

        public async Task<MasterBarangByIdResponse> Handle(MasterBarangByIdQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _context.MasterBarang.Where(x => x.NoUrutId == request.MasterBarangId).Select(x => new MasterBarangByIdResponse
            {
                NoUrutId = x.NoUrutId,
                MasterBarangIdGuid = x.MasterBarangId,
                NamaBarang = x.NamaBarang
            }).SingleOrDefaultAsync();
            return returnQuery;
        }
    }
}
