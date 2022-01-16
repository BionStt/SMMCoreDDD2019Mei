using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.FeatureManagement;
using SumberMas2015.Audit.Domain;
using SumberMas2015.Audit.Domain.Enum;
using SumberMas2015.Audit.Domain.Repository;
using SumberMas2015.Audit.Domain.Specifications;
using SumberMas2015.Audit.ServiceApplication.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Audit.ServiceApplication
{
    public class SumberMasAudit:ISumberMasAudit
    {
        private readonly ILogger<SumberMasAudit> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IFeatureManager _featureManager;
        private readonly IAuditLogRepository _auditLogRepo;

        public SumberMasAudit(ILogger<SumberMasAudit> logger, IHttpContextAccessor httpContextAccessor, IFeatureManager featureManager, IAuditLogRepository auditLogRepo)
        {
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
            _featureManager = featureManager;
            _auditLogRepo = auditLogRepo;
        }

        public async Task AddEntry(SumberMasEventType blogEventType, SumberMasEventId blogEventId, string message)
        {
            try
            {
                if (!await IsAuditLogEnabled()) return;

                var (username, ipv4) = GetUsernameAndIp();

                // Truncate data so that SQL won't blow up
                if (message.Length > 256) message = message[..256];

                var machineName = Environment.MachineName;
                if (machineName.Length > 32) machineName = machineName[..32];

                var entity = new AuditLogEntity
                {
                    EventId = blogEventId,
                    EventType = blogEventType,
                    EventTimeUtc = DateTime.UtcNow,
                    IpAddressV4 = ipv4,
                    MachineName = machineName,
                    Message = message,
                    WebUsername = username
                };
                await _auditLogRepo.AddAsync(entity);
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
            }
        }

        public async Task<(IReadOnlyList<AuditLogEntity> Entries, int Count)> GetAuditEntries(int skip, int take)
        {
            var spec = new AuditPagingSpec(take, skip);
            var entries = await _auditLogRepo.GetAsync(spec);

            var totalRows = _auditLogRepo.Count();
            var returnType = (entries.ToList(), totalRows);

            return returnType;
        }

        public async Task ClearAuditLog()
        {
            if (!await IsAuditLogEnabled()) return;

            await _auditLogRepo.ExecuteSqlRawAsync("DELETE FROM AuditLog");

            // Make sure who ever doing this can't get away with it
            var (username, ipv4) = GetUsernameAndIp();
            await AddEntry(SumberMasEventType.General, SumberMasEventId.ClearedAuditLog, $"Audit log was cleared by '{username}' from '{ipv4}'");
        }

        private (string Username, string Ipv4) GetUsernameAndIp()
        {
            var uname = string.Empty;
            var ip = "0.0.0.0";

            if (_httpContextAccessor?.HttpContext is not null)
            {
                uname = _httpContextAccessor.HttpContext.User.Identity?.Name ?? "N/A";
                ip = _httpContextAccessor.HttpContext.Connection.RemoteIpAddress?.ToString();
            }

            return (uname, ip);
        }

        private async Task<bool> IsAuditLogEnabled()
        {
            var flag = await _featureManager.IsEnabledAsync("EnableAudit");
            return flag;
        }

    }
}
