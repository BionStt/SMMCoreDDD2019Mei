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


namespace SmmCoreDDD2019.Application.DataPegawaiFotos.Queries.GetDataPegawaiList
{
    public class DataPegawaiListQueryHandler : IRequestHandler<DataPegawaiListQuery, DataPegawaiListViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public DataPegawaiListQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<DataPegawaiListViewModel> Handle(DataPegawaiListQuery request, CancellationToken cancellationToken)
        {
            return new DataPegawaiListViewModel
            {
                DataPegawaiFotoDs = await _context.DataPegawaiFoto.ProjectTo<DataPegawaiLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            };
        }
    }
}
