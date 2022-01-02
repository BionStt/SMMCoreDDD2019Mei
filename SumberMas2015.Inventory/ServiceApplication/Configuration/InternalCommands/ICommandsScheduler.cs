using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.ServiceApplication.Configuration.InternalCommands
{
    public interface ICommandsScheduler
    {
        Task EnqueueAsync(IRequest command);
    }
}
