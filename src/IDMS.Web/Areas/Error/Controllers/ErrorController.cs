using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDMS.Web.Areas.Error.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error/Error/NotFound
        public ActionResult NotFound(string aspxerrorpath = "")
        {
            return View();
        }

        // GET: Error/Error/UnderConstruction
        public ActionResult UnderConstruction(string aspxerrorpath = "")
        {
            return View();
        }

        // GET: Error/Error/TechnicalProblems
        public ActionResult TechnicalProblems(string aspxerrorpath = "")
        {
            return View();
        }
    }
}