using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;

using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SmmCoreDDD2019.Application.Interfaces;
using System.Threading;
namespace SmmCoreDDD2019.Application.CustomerDBs.Queries.GetCustomerByID
{
    public class GetCustomerByIDQueryHandler : IRequestHandler<GetCustomerByIDQuery, GetCustomerByIDViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetCustomerByIDQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetCustomerByIDViewModel> Handle(GetCustomerByIDQuery request, CancellationToken cancellationToken)
        {
            return new GetCustomerByIDViewModel
            {
                CustomerDs = await _context.CustomerDB.Where(x => x.CustomerID == Int32.Parse(request.Id)).ProjectTo<GetCustomerByIDLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            };
        }
    }
}
