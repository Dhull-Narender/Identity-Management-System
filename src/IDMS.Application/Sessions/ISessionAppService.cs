using System.Threading.Tasks;
using Abp.Application.Services;
using IDMS.Sessions.Dto;

namespace IDMS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
