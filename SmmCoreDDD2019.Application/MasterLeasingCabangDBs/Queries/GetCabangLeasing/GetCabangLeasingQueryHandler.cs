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
namespace SmmCoreDDD2019.Application.MasterLeasingCabangDBs.Queries.GetCabangLeasing
{
    public class GetCabangLeasingQueryHandler : IRequestHandler<GetCabangLeasingQuery, GetCabangLeasingViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetCabangLeasingQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetCabangLeasingViewModel> Handle(GetCabangLeasingQuery request, CancellationToken cancellationToken)
        {
            // TODO: Set view model state based on user permissions.
          var CabangLeasing = await (from a in _context.MasterLeasingDb
                                 join b in _context.MasterLeasingCabangDB on a.Id equals b.MasterLeasingDbId
                                 let NamaCab = a.NamaLease+" - "+b.Cabang
                                 select new {b.Id,NamaCab }
                                 ).OrderBy(x=>x.NamaCab).ToListAsync(cancellationToken);

            // var CabangLeasing = await (_context.MasterLeasingCabangDB.OrderBy(x=>x.Cabang).Include(p=>p.MasterLeasingDb).ToListAsync(cancellationToken));
            //return new GetCabangLeasingViewModel
            //{
            //    //  MasterLeasingCabangDs = await _context.CustomerDB.ProjectTo<GetCabangLeasingLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            //    MasterLeasingCabangDs = _mapper.Map<IList<GetCabangLeasingLookUpModel>>(CabangLeasing)

            //};
            var model = new GetCabangLeasingViewModel
            {
                MasterLeasingCabangDs = _mapper.Map<IEnumerable<GetCabangLeasingLookUpModel>>(CabangLeasing)
            };
            return model;
        }
    }
}
