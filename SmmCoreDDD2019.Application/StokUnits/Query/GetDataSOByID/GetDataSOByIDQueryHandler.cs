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
using SmmCoreDDD2019.Application.Exceptions;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Application.StokUnits.Query.GetDataSOByID
{
    public class GetDataSOByIDQueryHandler : IRequestHandler<GetDataSOByIDQuery, GetDataSOByIDViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;

        public GetDataSOByIDQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetDataSOByIDViewModel> Handle(GetDataSOByIDQuery request, CancellationToken cancellationToken)
        {
            //return new GetDataSOByIDViewModel
            //{
            //    DataKendaraanByNoUrutSODs = await _context.MasterBarangDB.ProjectTo<GetDataSOByIDLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            //};

            var DataStokUnit = await (from a in _context.StokUnit
                                      join b in _context.MasterBarangDB on a.MasterBarangDBId equals b.Id
                                         where a.Id == Int32.Parse(request.Id)
                                       select new { HargaOff =b.Harga, BBN = b. BBN}
                 ).ToListAsync(cancellationToken);

            if (DataStokUnit == null)
            {
                throw new NotFoundException(nameof(StokUnit), request.Id);
            }

            var model = new GetDataSOByIDViewModel
            {
                DataKendaraanByNoUrutSODs = _mapper.Map<IEnumerable<GetDataSOByIDLookUpModel>>(DataStokUnit)
            };
            return model;
        }
    }
}
