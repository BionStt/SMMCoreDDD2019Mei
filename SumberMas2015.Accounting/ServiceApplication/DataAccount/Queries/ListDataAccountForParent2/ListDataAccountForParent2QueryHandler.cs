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

namespace SumberMas2015.Accounting.ServiceApplication.DataAccount.Queries.ListDataAccountForParent2
{
    public class ListDataAccountForParent2QueryHandler : IRequestHandler<ListDataAccountForParent2Query, IReadOnlyCollection<ListDataAccountForParent2QueryResponse>>
    {
        private readonly AccountingDbContext _dbContext;

        public ListDataAccountForParent2QueryHandler(AccountingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IReadOnlyCollection<ListDataAccountForParent2QueryResponse>> Handle(ListDataAccountForParent2Query request, CancellationToken cancellationToken)
        {
            var returnQuery = await (from parent in _dbContext.DataAccounts
                                     from child in _dbContext.DataAccounts
                                     where child.Lft > parent.Lft && child.Lft < parent.Rgt && parent.NoUrutId == request.Data1
                                     orderby child.KodeAccount
                                     select new ListDataAccountForParent2QueryResponse
                                     {
                                         NoUrutId = child.NoUrutId,
                                         NamaAkun = "[ " + child.KodeAccount + " ] - " + child.Account + " - " + Analyze(child.Kelompok) + " - " + NormalPos(child.NormalPos)

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
