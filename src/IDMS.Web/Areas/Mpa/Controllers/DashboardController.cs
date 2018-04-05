using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using IDMS.Authorization;
using IDMS.Web.Controllers;

namespace IDMS.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Tenant_Dashboard)]
    public class DashboardController : IDMSControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}