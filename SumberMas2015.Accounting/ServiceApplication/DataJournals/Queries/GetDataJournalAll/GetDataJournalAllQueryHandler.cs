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

namespace SumberMas2015.Accounting.ServiceApplication.DataJournals.Queries.GetDataJournalAll
{
    public class GetDataJournalAllQueryHandler : IRequestHandler<GetDataJournalAllQuery, IReadOnlyCollection<GetDataJournalAllResponse>>
    {
        private readonly AccountingDbContext _dbContext;

        public GetDataJournalAllQueryHandler(AccountingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IReadOnlyCollection<GetDataJournalAllResponse>> Handle(GetDataJournalAllQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await (from a in _dbContext.DataJournalDetails
                                     join b in _dbContext.DataAccounts on a.DataAccountId equals b.DataAccountId into ps
                                     from b in ps.DefaultIfEmpty()
                                     join c in _dbContext.DataJournalHeaders on a.DataJournalHeaderId equals c.DataJournalHeaderId

                                     select new GetDataJournalAllResponse
                                     {
                                         AccountingDataAccountId = b.DataAccountId,
                                         AccountingDataJournalIdH = c.DataJournalHeaderId,
                                         DataAkun = b.KodeAccount + " - " + b.Account,
                                         Debit1 = a.Debit,
                                         Kredit1 = a.Kredit,
                                         Ket1 = a.Keterangan,
                                         TanggalInput = c.TanggalInput,
                                         NoBuktiJurnal = c.NoBuktiJournal
                                     }).AsNoTracking().ToListAsync(cancellationToken);

            return returnQuery;
        }
    }
}
