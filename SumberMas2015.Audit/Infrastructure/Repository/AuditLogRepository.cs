using Microsoft.EntityFrameworkCore;
using SumberMas2015.Audit.Domain;
using SumberMas2015.Audit.Domain.Repository;
using SumberMas2015.Audit.Domain.Specifications.Base;
using SumberMas2015.Audit.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Audit.Infrastructure.Repository
{
    public class AuditLogRepository : IAuditLogRepository
    {
        protected readonly AuditContext DbContext;

        public AuditLogRepository(AuditContext dbContext)
        {
            DbContext = dbContext;
        }
        private IQueryable<AuditLogEntity> ApplySpecification(ISpecification<AuditLogEntity> spec)
        {
            return SpecificationEvaluator<AuditLogEntity>.GetQuery(DbContext.Set<AuditLogEntity>().AsQueryable(), spec);
        }
        public async Task<AuditLogEntity> AddAsync(AuditLogEntity entity)
        {
            await DbContext.Set<AuditLogEntity>().AddAsync(entity);
            await DbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<IReadOnlyList<AuditLogEntity>> GetAsync(ISpecification<AuditLogEntity> spec)
        {
            return await ApplySpecification(spec).AsNoTracking().ToListAsync();
        }

        public int Count(ISpecification<AuditLogEntity> spec = null)
        {
            return null != spec ? ApplySpecification(spec).Count() : DbContext.Set<AuditLogEntity>().Count();
        }

        public async Task ExecuteSqlRawAsync(string sql)
        {
            await DbContext.Database.ExecuteSqlRawAsync(sql);
        }
    }
}
