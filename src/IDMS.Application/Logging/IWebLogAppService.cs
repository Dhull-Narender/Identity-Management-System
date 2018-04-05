using Abp.Application.Services;
using IDMS.Dto;
using IDMS.Logging.Dto;

namespace IDMS.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
