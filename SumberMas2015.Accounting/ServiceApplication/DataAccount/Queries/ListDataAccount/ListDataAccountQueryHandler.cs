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

namespace SumberMas2015.Accounting.ServiceApplication.DataAccount.Queries.ListDataAccount
{
    public class ListDataAccountQueryHandler : IRequestHandler<ListDataAccountQuery, IReadOnlyCollection<ListDataAccountQueryResponse>>
    {

        private readonly AccountingDbContext _dbContext;

        public ListDataAccountQueryHandler(AccountingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IReadOnlyCollection<ListDataAccountQueryResponse>> Handle(ListDataAccountQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _dbContext.DataAccounts.Select(x => new ListDataAccountQueryResponse
            {
                KodeAccount = x.KodeAccount,
                Account = x.Account,
                NormalPos = x.NormalPos,
                Kelompok = x.Kelompok,
                Depth= x.Depth,
                NoUrutId = x.NoUrutId

            }).AsNoTracking().OrderBy(x => x.KodeAccount).ToListAsync(cancellationToken);

            return returnQuery;
        }
    }
}
