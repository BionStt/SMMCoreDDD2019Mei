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

namespace SumberMas2015.Accounting.ServiceApplication.DataAccount.Queries.GetNamaAkunByNoUrutId
{
    public class GetNamaAkunByNoUrutIdQueryHandler : IRequestHandler<GetNamaAkunByNoUrutIdQuery, GetNamaAkunByNoUrutIdResponse>
    {
        private readonly AccountingDbContext _dbContext;

        public GetNamaAkunByNoUrutIdQueryHandler(AccountingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<GetNamaAkunByNoUrutIdResponse> Handle(GetNamaAkunByNoUrutIdQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _dbContext.DataAccounts.Where(x => x.NoUrutId== int.Parse(request.NoUrutId)).Select(x => new GetNamaAkunByNoUrutIdResponse
            {
                NamaAkun = "[ " + x.KodeAccount + " ] - " + x.Account + " - " + Analyze(x.Kelompok) + " - " + NormalPos(x.NormalPos)

            }).AsNoTracking().SingleOrDefaultAsync();

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
