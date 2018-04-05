using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using IDMS.Web.Areas.Mpa.Models.Common.Modals;
using IDMS.Web.Controllers;

namespace IDMS.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize]
    public class CommonController : IDMSControllerBase
    {
        public PartialViewResult LookupModal(LookupModalViewModel model)
        {
            return PartialView("Modals/_LookupModal", model);
        }
    }
}