using System.Web.Mvc;

namespace IDMS.Web.Controllers
{
    public class HomeController : IDMSControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NavigationHelper()
        {
            return View();
        }
    }
}