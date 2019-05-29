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

namespace SmmCoreDDD2019.Application.PembelianDetails.Query.GetLIstPembelian
{
    public class GetLIstPembelianQueryHandler : IRequestHandler<GetLIstPembelianQuery, GetLIstPembelianViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetLIstPembelianQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetLIstPembelianViewModel> Handle(GetLIstPembelianQuery request, CancellationToken cancellationToken)
        {
            var aa = await(from a in _context.Pembelian
                           join b in _context.MasterSupplierDB on a.Idsupplier equals b.IDSupplier
                           //   where a.Terinput == null
                           select new { NoUrutPembelian = a.KodeBeli, NamaPembelian = string.Format("{0}  - {1:d} - {2}", a.KodeBeli, a.TglBeli, b.NamaSupplier) }

                ).ToListAsync(cancellationToken);
            var model = new GetLIstPembelianViewModel
            {
                DataPembelianDs = _mapper.Map<IEnumerable<GetLIstPembelianLookUpModel>>(aa)
            };
            return model;
            //return new GetLIstPembelianViewModel
            //{
            //    DataPembelianDs = await _context.PembelianPO.ProjectTo<GetLIstPembelianLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            //};
        }
    }
}
