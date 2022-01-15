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

namespace SumberMas2015.Accounting.ServiceApplication.DataAccount.Queries.GetDataAccountByDepth
{
    public class GetDataAccountByDepthQueryHandler : IRequestHandler<GetDataAccountByDepthQuery, IReadOnlyCollection<GetDataAccountByDepthResponse>>
    {
        private readonly AccountingDbContext _dbContext;

        public GetDataAccountByDepthQueryHandler(AccountingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IReadOnlyCollection<GetDataAccountByDepthResponse>> Handle(GetDataAccountByDepthQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await (from a in _dbContext.DataAccounts
                                     from b in _dbContext.DataAccounts
                                     where a.Parent == b.NoUrutId.ToString() && a.Depth>=3

                                     select new GetDataAccountByDepthResponse
                                     {
                                         NoUrutId = a.NoUrutId,
                                         Account = b.Account,
                                         KodeAccount = a.KodeAccount,
                                         DataAkun1 = "[ " + a.KodeAccount + " ] - " + a.Account + " - " + Analyze(b.Kelompok) + " - " + NormalPos(b.NormalPos),
                                         DataAkun2 = b.KodeAccount + " - " + b.Account + " - " + Analyze(b.Kelompok) + " - " + NormalPos(b.NormalPos)

                                     }).AsNoTracking().ToListAsync(cancellationToken);

            return returnQuery;
        }
        static String Analyze(String value)
        {
            // Return a value for each argument.
            switch (value)
            {
                case "N":
                    return "NERACA";
                case "L":
                    return "Laba/Rugi";

                default:
                    return String.Empty;
            }
        }
        static String NormalPos(int? value)
        {
            // Return a value for each argument.
            switch (value)
            {
                case 1:
                    return "DEBIT";
                case -1:
                    return "KREDIT";

                default:
                    return String.Empty;
            }
        }


    }
}
