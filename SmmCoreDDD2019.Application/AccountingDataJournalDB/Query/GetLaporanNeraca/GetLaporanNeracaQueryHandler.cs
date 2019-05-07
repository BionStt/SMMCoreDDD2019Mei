using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SmmCoreDDD2019.Persistence;
using System.Threading;
namespace SmmCoreDDD2019.Application.AccountingDataJournalDB.Query.GetLaporanNeraca
{
    public class GetLaporanNeracaQueryHandler : IRequestHandler<GetLaporanNeracaQuery, GetLaporanNeracaViewModel>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;

        public GetLaporanNeracaQueryHandler(SMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetLaporanNeracaViewModel> Handle(GetLaporanNeracaQuery request, CancellationToken cancellationToken)
        {

                var aa = await(from a1 in _context.AccountingDataAccount
                           join b2 in _context.AccountingDataAccount on a1.Parent equals b2.NoUrutAccountId.ToString()
                           join c in _context.AccountingDataAccount on a1.NoUrutAccountId equals Int32.Parse(c.Parent)
                           join e in _context.AccountingDataAccount on b2.Parent equals e.NoUrutAccountId.ToString()
                           from d in _context.AccountingDataJournal.Where(x => x.NoUrutAccountId == c.NoUrutAccountId.ToString()).DefaultIfEmpty()
                           join f in _context.AccountingDataJournalHeader on d.NoUrutJournalH equals f.NoUrutJournalH.ToString()
                           where b2.Kelompok == "N" && (f.TanggalInput >= request.Tanggal1 && f.TanggalInput <= request.Tanggal2)
                           orderby a1.KodeAccount, c.KodeAccount, a1.Depth
                           let nm = c.KodeAccount + " - " + c.Account
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
                           })
                           .GroupBy(x => new { x.Account1a, x.KodeAccountParent, x.AccountParent, x.KodeAccountParent1, x.AccountParent1, x.KodeAccount1, x.nm, x.Depth, x.KodeAkunInduk, x.normalPosInduk })
                .Select(g => new
                {
                    nm = g.Key.nm,
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
                }).ToListAsync(cancellationToken);

            var model = new GetLaporanNeracaViewModel
            {
                LaporanNeracaDS = _mapper.Map<IEnumerable<GetLaporanNeracaLookUpModel>>(aa)
            };
            return model;
        }
    }
}
