using SumberMas2015.Accounting.ServiceApplication.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using System.Threading;
using SumberMas2015.Accounting.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace SumberMas2015.Accounting.ServiceApplication.TipeJournal.Queries.ListTipeJournal
{
    public class ListTipeJournalQueryHandler : IRequestHandler<ListTipeJournalQuery, IReadOnlyCollection<ListTIpeJournalResponse>>
    {
        private readonly AccountingDbContext _dbContext;

        public ListTipeJournalQueryHandler(AccountingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IReadOnlyCollection<ListTIpeJournalResponse>> Handle(ListTipeJournalQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _dbContext.TipeJournals.Select(x => new ListTIpeJournalResponse
            {
                NamaJournal=x.NamaJournal,
                NoUrutId= x.NoUrutId

            }).AsNoTracking().OrderBy(x => x.NoUrutId).ToListAsync(cancellationToken);

            return returnQuery;
        }
    }

}
