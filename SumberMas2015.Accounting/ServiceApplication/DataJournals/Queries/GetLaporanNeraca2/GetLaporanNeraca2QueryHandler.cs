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

namespace SumberMas2015.Accounting.ServiceApplication.DataJournals.Queries.GetLaporanNeraca2
{
    public class GetLaporanNeraca2QueryHandler : IRequestHandler<GetLaporanNeraca2Query, IReadOnlyCollection<GetLaporanNeraca2Response>>
    {
        private readonly AccountingDbContext _context;

        public GetLaporanNeraca2QueryHandler(AccountingDbContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyCollection<GetLaporanNeraca2Response>> Handle(GetLaporanNeraca2Query request, CancellationToken cancellationToken)
        {
            //b2.Kelompok == "N" &&
            var returnQuery = await (from a1 in _context.DataAccounts
                                     join b2 in _context.DataAccounts on a1.Parent equals b2.NoUrutId.ToString()
                                     join c in _context.DataAccounts on a1.NoUrutId.ToString() equals c.Parent
                                     join e in _context.DataAccounts on b2.Parent equals e.NoUrutId.ToString()
                                     from d in _context.DataJournalDetails.Where(x => x.DataAccountId == c.DataAccountId).DefaultIfEmpty()
                                     join f in _context.DataJournalHeaders on d.DataJournalHeaderId equals f.DataJournalHeaderId
                                     where b2.Kelompok == "N" && (f.TanggalInput >= request.Tanggal1 && f.TanggalInput <= request.Tanggal2)

                                     orderby a1.KodeAccount, c.KodeAccount, a1.Depth
                                     //  let nm = a1.KodeAccount + " - " + c.KodeAccount + " - " + c.Account1
                                     let nm = c.KodeAccount + " - " + c.Account
                                     //   group d by c.KodeAccount into g
                                     //&& c.Depth== 3
                                     select new
                                     {
                                         nm,
                                         a1.Depth,
                                         KodeAkunInduk = e.KodeAccount + " - " + e.Account,
                                         normalPosInduk = e.NormalPos,
                                         KodeAccountParent = b2.KodeAccount + " - " + b2.Account,
                                         AccountParent = b2.Account,
                                         KodeAccountParent1 = a1.KodeAccount,
                                         AccountParent1 = a1.Account,
                                         KodeAccount1 = c.KodeAccount,
                                         Account1a = c.Account,
                                         Debit1 = d.Debit ?? 0,
                                         Kredit1 = d.Kredit ?? 0,
                                         Saldo1 = ((d.Debit ?? 0) - d.Kredit ?? 0) * c.NormalPos

                                     }

                  ).GroupBy(x => new { x.Account1a, x.KodeAccountParent, x.AccountParent, x.KodeAccountParent1, x.AccountParent1, x.KodeAccount1, x.nm, x.Depth, x.KodeAkunInduk, x.normalPosInduk })
                  .Select(g => new GetLaporanNeraca2Response
                  {
                      NamaAkun = g.Key.nm,
                      depth1 = g.Key.Depth,
                      normalPosInduk = g.Key.normalPosInduk,
                      KodeAkunInduk = g.Key.KodeAkunInduk,
                      KodeAccountParent = g.Key.KodeAccountParent,
                      AccountParent = g.Key.AccountParent,
                      KodeAccountParent1 = g.Key.KodeAccountParent1,
                      AccountParent1 = g.Key.AccountParent1,
                      KodeAccount1 = g.Key.KodeAccount1,
                      Account1a = g.Key.Account1a,
                      Debit1 = g.Sum(x => x.Debit1),
                      Kredit1 = g.Sum(x => x.Kredit1),
                      Saldo1 = g.Sum(x => x.Saldo1)
                  }).OrderBy(x => x.KodeAccountParent1).AsNoTracking().ToListAsync();

            return returnQuery;
        }
    }
}
