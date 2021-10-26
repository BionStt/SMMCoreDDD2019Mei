using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.Inventory.Dto.StokUnit;
using SumberMas2015.Inventory.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.ServiceApplication.StokUnit.Queries.GetListStokUnitByNoKodeBeli
{
    public class GetListStokUnitByNoKodeBeliQueryHandler : IRequestHandler<GetListStokUnitByNoKodeBeliQuery, IReadOnlyCollection<GetListStokUnitByNoKodeBeliResponse>>
    {
        private readonly InventoryContext _context;

        public GetListStokUnitByNoKodeBeliQueryHandler(InventoryContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyCollection<GetListStokUnitByNoKodeBeliResponse>> Handle(GetListStokUnitByNoKodeBeliQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await (from a in _context.StokUnit
                                     join b in _context.MasterBarang on a.MasterBarangId equals b.MasterBarangId
                                     where a.NoUrutId == int.Parse(request.Id)
                                     select new GetListStokUnitByNoKodeBeliResponse {
                                         NoUrutSO = a.NoUrutId,
                                         NamaBarang1 = String.Format("{0} - {1} - {2:c} - {3:c} - {4:c}",b.Merek,b.NamaBarang,b.HargaOff,b.Bbn,b.HargaOff+b.Bbn),
                                         NoRangka1 = a.NomorRangka,
                                         NoMesin1 = a.NomorMesin,
                                         Warna1 = a.Warna
                                     }).AsNoTracking().ToListAsync();


            return returnQuery;
        }
    }
}
