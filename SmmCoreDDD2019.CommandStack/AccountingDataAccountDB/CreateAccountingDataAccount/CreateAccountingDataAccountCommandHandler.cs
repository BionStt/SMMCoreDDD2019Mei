using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Threading;

using SmmCoreDDD2019.Application.Interfaces;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.CommandStack.AccountingDataAccountDB.CreateAccountingDataAccount
{
    public class CreateAccountingDataAccountCommandHandler : IRequestHandler<CreateAccountingDataAccountCommand>
    {

        private readonly ISMMCoreDDD2019DbContext _database;
        private readonly ILogger _logger;

        public CreateAccountingDataAccountCommandHandler(IServiceProvider serviceProvider)
        {
            _database = serviceProvider.GetService<ISMMCoreDDD2019DbContext>();
            _logger = serviceProvider.GetService<ILogger<CreateAccountingDataAccountCommandHandler>>();
        }

        public async Task<Unit> Handle(CreateAccountingDataAccountCommand request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Executing CreateAccountingDataAccountCommand");

            try
            {
                string NilaiParent;
                if (request.Parent == "0")
                {
                    NilaiParent = null;
                }
                else
                {
                    NilaiParent = request.Parent;

                };

                var entity = new AccountingDataAccount
                {
                    KodeAccount = request.KodeAccount,
                    Account = request.Account,
                    NormalPos = request.NormalPos,
                    Kelompok = request.Kelompok,
                    AccountingDataMataUangId = request.AccountingDataMataUangId,
                    //  Parent = request.Parent
                    Parent = NilaiParent
                };

                _database.AccountingDataAccount.Add(entity);

                //foreach (var transaction in request.AccountingDataAccounts)
                //    _database.AccountingDataAccount.Add(transaction);

                await _database.SaveChangesAsync(cancellationToken);
               // _database.Save();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error executing 'Save Transactions' command");
                throw;
            }
            return Unit.Value;
           // return Unit.Task;
        }
    }
}
