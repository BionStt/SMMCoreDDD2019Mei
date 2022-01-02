﻿using SumberMas2015.DDD.EventBus;
using SumberMas2015.DDD.OutBox.Domain;
using SumberMas2015.Inventory.EventBus;
using SumberMas2015.Inventory.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.InfrastructureData.EventBus
{
    public class InventoryEventBus : IInventoryEventBus
    {
        private readonly InventoryContext _dbContext;

        public InventoryEventBus(InventoryContext dbContext)
        {
            _dbContext=dbContext;
        }

        public async  Task Publish(IIntegrationEvent @event)
        {
            throw new NotImplementedException();
        }

        public async Task PublishMany(IEnumerable<IIntegrationEvent> events)
        {
            throw new NotImplementedException();
        }
        private async Task PersistIntegrationEvent(IIntegrationEvent @event)
        {
            var outBoxMessage = OutBoxMessage.New(@event);
            await _dbContext.OutBoxMessages.AddAsync(outBoxMessage);
            await _dbContext.SaveChangesAsync();

        }
    }
}
