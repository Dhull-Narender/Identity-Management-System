using Abp.IdentityFramework;
using Abp.Web.Mvc.Controllers;
using Microsoft.AspNet.Identity;

namespace IDMS.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// Add your methods to this class common for all controllers.
    /// </summary>
    public abstract class IDMSControllerBase : AbpController
    {
        protected IDMSControllerBase()
        {
            LocalizationSourceName = IDMSConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}