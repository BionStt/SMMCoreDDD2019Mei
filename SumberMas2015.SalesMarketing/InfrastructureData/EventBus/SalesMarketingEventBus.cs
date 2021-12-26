﻿ using SumberMas2015.SalesMarketing.EventBus;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.InfrastructureData.EventBus
{
    public class SalesMarketingEventBus : InMemoryEventBus, ISalesMarketingEventBus
    {
        public SalesMarketingEventBus(SalesMarketingContext dbContext) : base(dbContext)
        {
        }
    }
}
