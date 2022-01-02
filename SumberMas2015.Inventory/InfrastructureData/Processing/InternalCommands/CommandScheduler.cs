using MediatR;
using SumberMas2015.DDD.InternalCommand.Domain;
using SumberMas2015.Inventory.InfrastructureData.Context;
using SumberMas2015.Inventory.ServiceApplication.Configuration.InternalCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.InfrastructureData.Processing.InternalCommands
{
    public class CommandScheduler : ICommandsScheduler
    {
        private readonly InventoryContext _dbContext;

        public CommandScheduler(InventoryContext dbContext)
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
