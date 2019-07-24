using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using SmmCoreDDD2019.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.QueryStack.AccountingDataAccountDB.GetAllDataAccountOrderByKodeAccount
{
    public class GetAllDataAccountOrderByKodeAccountQueryHandler : IRequestHandler<GetAllDataAccountOrderByKodeAccountQuery, List<AccountingDataAccount>>
    {
        private readonly ISMMCoreDDD2019DbContext _database;
        private readonly ILogger _logger;

        public GetAllDataAccountOrderByKodeAccountQueryHandler(IServiceProvider serviceProvider)
        {
            _database = serviceProvider.GetService<ISMMCoreDDD2019DbContext>();
            _logger = serviceProvider.GetService<ILogger<GetAllDataAccountOrderByKodeAccountQueryHandler>>();
        }

        public Task<List<AccountingDataAccount>> Handle(GetAllDataAccountOrderByKodeAccountQuery request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Getting Transactions List");

            try
            {
                return _database.AccountingDataAccount.ToListAsync(cancellationToken: cancellationToken);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error Getting Transactions List");
                throw;
            }
        }
    }
}
