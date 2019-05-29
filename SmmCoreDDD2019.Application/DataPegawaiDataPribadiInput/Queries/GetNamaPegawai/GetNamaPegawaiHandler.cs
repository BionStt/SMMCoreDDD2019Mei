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

namespace SmmCoreDDD2019.Application.DataPegawaiDataPribadiInput.Queries.GetNamaPegawai
{
    public class GetNamaPegawaiHandler : IRequestHandler<GetNamaPegawaiQuery, GetNamaPegawaiViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetNamaPegawaiHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetNamaPegawaiViewModel> Handle(GetNamaPegawaiQuery request, CancellationToken cancellationToken)
        {
            return new GetNamaPegawaiViewModel
            {
                DataPegawaiDtPribadiDs = await _context.DataPegawaiDataPribadi.ProjectTo<GetNamaPegawaiLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            };

          
        }
    }
}
