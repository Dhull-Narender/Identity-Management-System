using System.Web.Mvc;

namespace IDMS.Web.Controllers
{
    public class AboutController : IDMSControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}