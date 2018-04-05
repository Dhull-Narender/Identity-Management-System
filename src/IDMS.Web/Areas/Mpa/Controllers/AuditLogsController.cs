using System.Web.Mvc;
using Abp.Auditing;
using Abp.Web.Mvc.Authorization;
using IDMS.Authorization;
using IDMS.Web.Controllers;

namespace IDMS.Web.Areas.Mpa.Controllers
{
    [DisableAuditing]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_AuditLogs)]
    public class AuditLogsController : IDMSControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}