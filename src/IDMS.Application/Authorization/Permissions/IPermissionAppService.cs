using Abp.Application.Services;
using Abp.Application.Services.Dto;
using IDMS.Authorization.Permissions.Dto;

namespace IDMS.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
