using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SmmCoreDDD2019.Persistence.Infrastructure;

namespace SmmCoreDDD2019.Persistence
{
   public class SMMCoreDDD2019DbContextFactory:DesignTimeDbContextFactoryBase<SMMCoreDDD2019DbContext>
    {
        protected override SMMCoreDDD2019DbContext CreateNewInstance(DbContextOptions<SMMCoreDDD2019DbContext> options)
        {
            return new SMMCoreDDD2019DbContext(options);
          //  throw new NotImplementedException();
        }
    }
}
