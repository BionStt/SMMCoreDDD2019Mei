using SumberMas2015.Inventory.EventBus;
using SumberMas2015.Inventory.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.InfrastructureData.EventBus
{
    public class InventoryEventBus : InMemoryEventBus, IInventoryEventBus
    {
        public InventoryEventBus(InventoryContext dbContext) : base(dbContext)
        {
        }
    }
}
