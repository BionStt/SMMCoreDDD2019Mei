using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SmmCoreDDD2019.Application.Interfaces;
using System.Threading;

namespace SmmCoreDDD2019.Application.PembelianDetails.Query.GetKodeBeli
{
    public class GetKodeBeliQueryHandler : IRequestHandler<GetKodeBeliQuery, GetKodeBeliViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetKodeBeliQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetKodeBeliViewModel> Handle(GetKodeBeliQuery request, CancellationToken cancellationToken)
        {
            var aa = await (from a in _context.Pembelian
                            join b in _context.MasterSupplierDB on a.MasterSupplierDBId equals b.Id
                         //   where a.Terinput == null
                            select new { NoUrutPembelian = a.Id, NamaPembelian = string.Format("{0}  - {1:d} - {2}", a.Id, a.TglBeli, b.NamaSupplier) }

               ).ToListAsync(cancellationToken);
            var model = new GetKodeBeliViewModel
            {
                DataPembelianDS = _mapper.Map<IEnumerable<GetKodeBeliLookUpModel>>(aa)
            };
            return model;
            //return new GetKodeBeliViewModel
            //{
            //    DataPembelianDS = await _context.PembelianPO.ProjectTo<GetKodeBeliLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            //};
        }
    }
}
