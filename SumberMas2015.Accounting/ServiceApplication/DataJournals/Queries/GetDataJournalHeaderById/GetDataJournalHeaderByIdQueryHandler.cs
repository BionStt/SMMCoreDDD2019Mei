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

namespace SumberMas2015.Accounting.ServiceApplication.DataJournals.Queries.GetDataJournalHeaderById
{
    public class GetDataJournalHeaderByIdQueryHandler : IRequestHandler<GetDataJournalHeaderByIdQuery, GetDataJournalHeaderByIdResponse>
    {
        private readonly AccountingDbContext _dbContext;

        public GetDataJournalHeaderByIdQueryHandler(AccountingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<GetDataJournalHeaderByIdResponse> Handle(GetDataJournalHeaderByIdQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _dbContext.DataJournalHeaders.Where(x => x.DataJournalHeaderId == request.KodeJournalHeaderId).Select(x => new GetDataJournalHeaderByIdResponse
            {
                TanggalInput = x.TanggalInput,
                Keterangan = x.Keterangan,
                NoBuktiJournalHeader = x.NoBuktiJournal

            }).AsNoTracking().SingleOrDefaultAsync(cancellationToken);

            return returnQuery;
        }
    }
}
