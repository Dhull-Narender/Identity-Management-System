using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using IDMS.Authorization;

namespace IDMS
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(typeof(IDMSCoreModule))]
    public class IDMSApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper mappings
            Configuration.Modules.AbpAutoMapper().Configurators.Add(mapper =>
            {
                CustomDtoMapper.CreateMappings(mapper);
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
