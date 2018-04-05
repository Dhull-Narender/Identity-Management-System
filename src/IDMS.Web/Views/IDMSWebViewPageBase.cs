using Abp.Dependency;
using Abp.Runtime.Session;
using Abp.Web.Mvc.Views;

namespace IDMS.Web.Views
{
    public abstract class IDMSWebViewPageBase : IDMSWebViewPageBase<dynamic>
    {
       
    }

    public abstract class IDMSWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        public IAbpSession AbpSession { get; private set; }
        
        protected IDMSWebViewPageBase()
        {
            AbpSession = IocManager.Instance.Resolve<IAbpSession>();
            LocalizationSourceName = IDMSConsts.LocalizationSourceName;
        }
    }
}