using Abp.Authorization;
using Abp.Configuration;
using Abp.Domain.Uow;
using IDMS.Authorization.Roles;
using IDMS.Authorization.Users;
using IDMS.MultiTenancy;
using Microsoft.Owin.Security;

namespace IDMS.Web.Auth
{
    public class SignInManager : AbpSignInManager<Tenant, Role, User>
    {
        public SignInManager(
            UserManager userManager, 
            IAuthenticationManager authenticationManager, 
            ISettingManager settingManager,
            IUnitOfWorkManager unitOfWorkManager) 
            : base(
                  userManager, 
                  authenticationManager,
                  settingManager,
                  unitOfWorkManager)
        {
        }
    }
}