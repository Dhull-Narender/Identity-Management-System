using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using IDMS.Authorization.Users.Dto;

namespace IDMS.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<ListResultDto<UserLoginAttemptDto>> GetRecentUserLoginAttempts();
    }
}
