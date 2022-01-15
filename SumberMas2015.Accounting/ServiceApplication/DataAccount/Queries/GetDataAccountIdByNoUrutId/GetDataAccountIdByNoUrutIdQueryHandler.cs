using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.Accounting.Infrastructure.Context;
using SumberMas2015.Accounting.ServiceApplication.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.Accounting.ServiceApplication.DataAccount.Queries.GetDataAccountIdByNoUrutId
{
    public class GetDataAccountIdByNoUrutIdQueryHandler : IRequestHandler<GetDataAccountIdByNoUrutIdQuery, GetDataAccountIdByNoUrutIdResponse>
    {
        private readonly AccountingDbContext _dbContext;

        public GetDataAccountIdByNoUrutIdQueryHandler(AccountingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<GetDataAccountIdByNoUrutIdResponse> Handle(GetDataAccountIdByNoUrutIdQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _dbContext.DataAccounts.Where(x => x.NoUrutId == request.NoUrutId).Select(x => new GetDataAccountIdByNoUrutIdResponse
            {
                NoUrutId = x.NoUrutId,
                DataAccountId = x.DataAccountId
            }).SingleOrDefaultAsync();

            return returnQuery;
        }
    }
}
