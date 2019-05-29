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

namespace SmmCoreDDD2019.Application.MasterBarangDBs.Queries.GetNamaBarangQr
{
    public class GetNamaBarangQrHandler : IRequestHandler<GetNamaBarangQrQuery, GetNamaBarangQrViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetNamaBarangQrHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetNamaBarangQrViewModel> Handle(GetNamaBarangQrQuery request, CancellationToken cancellationToken)
        {
            return new GetNamaBarangQrViewModel
            {
                MasterBarangDs = await _context.MasterBarangDB.ProjectTo<GetNamaBarangQrLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            };
        }
    }
}
