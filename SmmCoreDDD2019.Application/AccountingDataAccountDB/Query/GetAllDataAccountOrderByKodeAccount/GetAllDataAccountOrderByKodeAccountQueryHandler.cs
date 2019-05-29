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

namespace SmmCoreDDD2019.Application.AccountingDataAccountDB.Query.GetAllDataAccountOrderByKodeAccount
{
    public class GetAllDataAccountOrderByKodeAccountQueryHandler : IRequestHandler<GetAllDataAccountOrderByKodeAccountQuery, GetAllDataAccountOrderByKodeAccountViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;

        public GetAllDataAccountOrderByKodeAccountQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetAllDataAccountOrderByKodeAccountViewModel> Handle(GetAllDataAccountOrderByKodeAccountQuery request, CancellationToken cancellationToken)
        {
            return new GetAllDataAccountOrderByKodeAccountViewModel
            {
                DataAccountDs = await _context.AccountingDataAccount.ProjectTo<GetAllDataAccountOrderByKodeAccountLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            };

        }
    }
}
