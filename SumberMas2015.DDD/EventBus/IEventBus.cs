using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.DDD.EventBus
{
    public interface IEventBus
    {
        public Task Publish(IIntegrationEvent @event);
        Task PublishMany(IEnumerable<IIntegrationEvent> @events);
    }
}
