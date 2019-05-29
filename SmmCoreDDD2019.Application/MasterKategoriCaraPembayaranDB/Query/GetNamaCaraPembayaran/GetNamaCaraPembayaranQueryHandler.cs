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

namespace SmmCoreDDD2019.Application.MasterKategoriCaraPembayaranDB.Query.GetNamaCaraPembayaran
{
    public class GetNamaCaraPembayaranQueryHandler : IRequestHandler<GetNamaCaraPembayaranQuery, GetNamaCaraPembayaranViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetNamaCaraPembayaranQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetNamaCaraPembayaranViewModel> Handle(GetNamaCaraPembayaranQuery request, CancellationToken cancellationToken)
        {
            return new GetNamaCaraPembayaranViewModel
            {
                MasterCaraPembayaranDs = await _context.MasterKategoriCaraPembayaran.ProjectTo<GetNamaCaraPembayaranLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            };
        }
    }
}
