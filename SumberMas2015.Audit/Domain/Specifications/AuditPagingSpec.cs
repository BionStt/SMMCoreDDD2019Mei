using SumberMas2015.Audit.Domain.Specifications.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Audit.Domain.Specifications
{
    public class AuditPagingSpec : BaseSpecification<AuditLogEntity>
    {
        public AuditPagingSpec(int pageSize, int offset) : base()
        {
            ApplyPaging(offset, pageSize);
            ApplyOrderByDescending(p => p.EventTimeUtc);
        }
    }
}
