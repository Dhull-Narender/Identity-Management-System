using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using IDMS.Web.Controllers;

namespace IDMS.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize]
    public class WelcomeController : IDMSControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}