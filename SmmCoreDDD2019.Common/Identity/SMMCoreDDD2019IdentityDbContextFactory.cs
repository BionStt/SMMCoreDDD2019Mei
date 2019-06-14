using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmmCoreDDD2019.Common.Infrastructure;
namespace SmmCoreDDD2019.Common.Identity
{
    public class SMMCoreDDD2019IdentityDbContextFactory : DesignTimeIdentityDbContextFactoryBase<AppIdentityDbContext>
    {
        protected override AppIdentityDbContext CreateNewInstance(DbContextOptions<AppIdentityDbContext> options)
        {
            return new AppIdentityDbContext(options);
            //  throw new NotImplementedException();
        }
    }
}
