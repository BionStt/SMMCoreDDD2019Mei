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

namespace SumberMas2015.Inventory.ServiceApplication.MasterBarang.Queries.GetNamaBarangQrByNoUrut
{
    public class GetNamaBarangQrByNoUrutQueryHandler : IRequestHandler<GetNamaBarangQrByNoUrutQuery, GetNamaBarangQrByNoUrutResponse>
    {
        private readonly InventoryContext _context;

        public GetNamaBarangQrByNoUrutQueryHandler(InventoryContext context)
        {
            _context = context;
        }

        public async  Task<GetNamaBarangQrByNoUrutResponse> Handle(GetNamaBarangQrByNoUrutQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await (from a in _context.MasterBarang
                                     where a.NoUrutId ==int.Parse(request.Id)
                                     select new GetNamaBarangQrByNoUrutResponse {
                                         BBN1 = a.Bbn,
                                         HargaOff = a.HargaOff

                                     }

                ).AsNoTracking().SingleOrDefaultAsync();

            return returnQuery;
        }
    }
}
