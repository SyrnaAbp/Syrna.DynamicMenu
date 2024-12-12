using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Syrna.DynamicMenu
{
    [DependsOn(
        typeof(AbpDynamicMenuDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class AbpDynamicMenuApplicationContractsModule : AbpModule
    {

    }
}
