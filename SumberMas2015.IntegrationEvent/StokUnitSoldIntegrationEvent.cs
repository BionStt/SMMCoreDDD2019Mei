using MediatR;
using SumberMas2015.DDD.EventBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.IntegrationEvent
{
    public class StokUnitSoldIntegrationEvent : INotification, IIntegrationEvent
    {
        public StokUnitSoldIntegrationEvent(Guid stokUnitId)
        {
            StokUnitId=stokUnitId;
        }

        public Guid StokUnitId { get; set; }
    }
}
