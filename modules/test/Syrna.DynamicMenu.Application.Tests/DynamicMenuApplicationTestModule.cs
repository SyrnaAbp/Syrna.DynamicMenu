using Volo.Abp.Modularity;

namespace Syrna.DynamicMenu
{
    [DependsOn(
        typeof(AbpDynamicMenuApplicationModule),
        typeof(DynamicMenuDomainTestModule)
        )]
    public class DynamicMenuApplicationTestModule : AbpModule
    {

    }
}
