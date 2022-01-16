using SumberMas2015.Audit.Domain;
using SumberMas2015.Audit.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Audit.ServiceApplication.Contracts
{
    public interface ISumberMasAudit
    {
        Task AddEntry(SumberMasEventType blogEventType, SumberMasEventId blogEventId, string message);

        Task<(IReadOnlyList<AuditLogEntity> Entries, int Count)> GetAuditEntries(int skip, int take);

        Task ClearAuditLog();
    }
}
