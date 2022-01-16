using Microsoft.EntityFrameworkCore;
using SumberMas2015.Audit.Domain;
using SumberMas2015.Audit.Infrastructure.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Audit.Infrastructure.Context
{
    public class AuditContext : DbContext
    {
        public AuditContext()
        {

        }

        public AuditContext(DbContextOptions<AuditContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AuditLogConfiguration());
        }
        public virtual DbSet<AuditLogEntity> AuditLog { get; set; }

        
    }
}
