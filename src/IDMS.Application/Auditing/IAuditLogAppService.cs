using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using IDMS.Auditing.Dto;
using IDMS.Dto;

namespace IDMS.Auditing
{
    public interface IAuditLogAppService : IApplicationService
    {
        Task<PagedResultDto<AuditLogListDto>> GetAuditLogs(GetAuditLogsInput input);

        Task<FileDto> GetAuditLogsToExcel(GetAuditLogsInput input);
    }
}