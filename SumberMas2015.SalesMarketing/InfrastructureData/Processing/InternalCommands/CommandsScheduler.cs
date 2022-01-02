using MediatR;
using SumberMas2015.DDD.InternalCommand.Domain;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using SumberMas2015.SalesMarketing.ServiceApplication.Configuration.InternalCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.InfrastructureData.Processing.InternalCommands
{
    public class CommandsScheduler : ICommandsScheduler
    {
        private readonly SalesMarketingContext _dbContext;

        public CommandsScheduler(SalesMarketingContext dbContext)
        {
            _dbContext=dbContext;
        }

        public async Task EnqueueAsync(IRequest command)
        {
            await PersistInternalCommand(command);
        }
        private async Task PersistInternalCommand(IRequest @command)
        {
            var internalCommandMessage = InternalCommand.New(@command);
            await _dbContext.InternalCommands.AddAsync(internalCommandMessage);
            await _dbContext.SaveChangesAsync();

        }
    }
}
