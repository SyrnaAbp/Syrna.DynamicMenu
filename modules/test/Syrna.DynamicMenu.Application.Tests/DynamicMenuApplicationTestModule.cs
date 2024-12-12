using Volo.Abp.Modularity;

namespace Syrna.DynamicMenu
{
    [DependsOn(
        typeof(DynamicMenuApplicationModule),
        typeof(DynamicMenuDomainTestModule)
        )]
    public class DynamicMenuApplicationTestModule : AbpModule
    {

    }
}
