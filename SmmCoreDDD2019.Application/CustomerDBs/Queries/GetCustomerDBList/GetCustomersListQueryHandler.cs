using System;
using System.Collections.Generic;
using System.Text;

using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SmmCoreDDD2019.Persistence;
using System.Threading;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Application.CustomerDBs.Queries.GetCustomerDBList
{
    public class GetCustomersListQueryHandler : IRequestHandler<GetCustomersListQuery, CustomersListViewModel>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;

        public GetCustomersListQueryHandler(SMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CustomersListViewModel> Handle(GetCustomersListQuery request, CancellationToken cancellationToken)
        {
            return new CustomersListViewModel
            {
                Customers = await _context.CustomerDB.ProjectTo<CustomerLookupModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            };
        }
    }
}
