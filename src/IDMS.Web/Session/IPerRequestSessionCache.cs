using System.Threading.Tasks;
using IDMS.Sessions.Dto;

namespace IDMS.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
