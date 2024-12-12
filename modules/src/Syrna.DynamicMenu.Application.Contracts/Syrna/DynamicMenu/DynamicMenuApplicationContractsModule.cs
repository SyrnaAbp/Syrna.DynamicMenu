using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Syrna.DynamicMenu
{
    [DependsOn(
        typeof(DynamicMenuDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class DynamicMenuApplicationContractsModule : AbpModule
    {

    }
}
