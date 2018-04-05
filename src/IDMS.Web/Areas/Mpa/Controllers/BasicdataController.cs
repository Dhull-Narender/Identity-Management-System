using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using IDMS.Authorization;
using IDMS.Web.Controllers;

namespace IDMS.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Basicdata)]
    public class BasicdataController:IDMSControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}