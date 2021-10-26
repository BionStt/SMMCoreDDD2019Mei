using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.SalesMarketing.Dto.MasterKategoriCaraPembayaran;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.MasterKategoriCaraPembayaran.Queries.ListKategoriCaraPembayaran
{
    public class ListKategoriCaraPembayaranQueryHandler : IRequestHandler<ListKategoriCaraPembayaranQuery, IReadOnlyCollection<ListKategoriCaraPembayaranResponse>>
    {
        private readonly SalesMarketingContext _context;

        public ListKategoriCaraPembayaranQueryHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyCollection<ListKategoriCaraPembayaranResponse>> Handle(ListKategoriCaraPembayaranQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _context.MasterKategoriCaraPembayaran.Select(x=>new ListKategoriCaraPembayaranResponse {

                NoUrutId = x.NoUrutId,
                KategoriCaraPembayaran = x.CaraPembayaran
            }).AsNoTracking().ToListAsync();

            return returnQuery;
        }
    }
}
