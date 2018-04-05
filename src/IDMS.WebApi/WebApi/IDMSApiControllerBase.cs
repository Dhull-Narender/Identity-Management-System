using Abp.WebApi.Controllers;

namespace IDMS.WebApi
{
    public abstract class IDMSApiControllerBase : AbpApiController
    {
        protected IDMSApiControllerBase()
        {
            LocalizationSourceName = IDMSConsts.LocalizationSourceName;
        }
    }
}