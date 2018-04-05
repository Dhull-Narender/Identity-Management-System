using Abp.Application.Services;
using IDMS.Tenants.Dashboard.Dto;

namespace IDMS.Tenants.Dashboard
{
    public interface ITenantDashboardAppService : IApplicationService
    {
        GetMemberActivityOutput GetMemberActivity();
    }
}
