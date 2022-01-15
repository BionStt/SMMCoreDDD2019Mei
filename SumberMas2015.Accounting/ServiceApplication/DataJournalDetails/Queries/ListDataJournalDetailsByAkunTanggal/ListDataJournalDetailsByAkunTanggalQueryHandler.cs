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

namespace SumberMas2015.Accounting.ServiceApplication.DataJournalDetails.Queries.ListDataJournalDetailsByAkunTanggal
{
    public class ListDataJournalDetailsByAkunTanggalQueryHandler : IRequestHandler<ListDataJournalDetailsByAkunTanggalQuery, IReadOnlyCollection<ListDataJournalDetailsByAkunTanggalResponse>>
    {
        private readonly AccountingDbContext _dbContext;

        public ListDataJournalDetailsByAkunTanggalQueryHandler(AccountingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IReadOnlyCollection<ListDataJournalDetailsByAkunTanggalResponse>> Handle(ListDataJournalDetailsByAkunTanggalQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await (from a in _dbContext.DataJournalDetails
                                     join b in _dbContext.DataAccounts on a.DataAccountId equals b.DataAccountId
                                     join c in _dbContext.DataJournalHeaders on a.DataJournalHeaderId equals c.DataJournalHeaderId
                                     where b.NoUrutId == int.Parse(request.NoUrutId)  && (c.TanggalInput.Date >= request.PeriodeAwal.Date && c.TanggalInput.Date <= request.PeriodeAkhir.Date)
                                     select new ListDataJournalDetailsByAkunTanggalResponse
                                     {
                                         NoUrutId = b.NoUrutId,
                                         NoIdBUkti = a.NoUrutId,
                                         KodeNamaAkun = b.KodeAccount + " - " + b.Account,
                                         Debit1 = a.Debit,
                                         Kredit1 = a.Kredit,
                                         Keterangan = a.Keterangan,
                                         TanggalInput = c.TanggalInput,
                                         NoBuktiJurnal = c.NoBuktiJournal
                                     }).AsNoTracking().ToListAsync();


            return returnQuery;
        }
    }
}
