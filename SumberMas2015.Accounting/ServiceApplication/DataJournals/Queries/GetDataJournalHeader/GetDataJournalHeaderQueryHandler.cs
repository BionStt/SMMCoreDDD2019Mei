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

namespace SumberMas2015.Accounting.ServiceApplication.DataJournals.Queries.GetDataJournalHeader
{
    public class GetDataJournalHeaderQueryHandler : IRequestHandler<GetDataJournalHeaderQuery, IReadOnlyCollection<GetDataJournalHeaderQueryResponse>>
    {
        private readonly AccountingDbContext _dbContext;

        public GetDataJournalHeaderQueryHandler(AccountingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IReadOnlyCollection<GetDataJournalHeaderQueryResponse>> Handle(GetDataJournalHeaderQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _dbContext.DataJournalHeaders.Select(x => new GetDataJournalHeaderQueryResponse
            {
                DataJournalHeaderId = x.DataJournalHeaderId,
                NoUrutId = x.NoUrutId,
                JournalHeaders = string.Format("{0:d}", x.TanggalInput) + " - " + x.NoBuktiJournal + " - " + x.Keterangan

            }).AsNoTracking().ToListAsync(cancellationToken);

            return returnQuery;
        }
    }
}
