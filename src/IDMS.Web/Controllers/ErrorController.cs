using System.Web.Mvc;
using Abp.Auditing;

namespace IDMS.Web.Controllers
{
    public class ErrorController : IDMSControllerBase
    {
        [DisableAuditing]
        public ActionResult E404()
        {
            return View();
        }
    }
}