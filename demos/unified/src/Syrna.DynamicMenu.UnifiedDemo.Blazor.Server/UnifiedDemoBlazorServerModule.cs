using Volo.Abp.Modularity;

namespace Syrna.DynamicMenu.UnifiedDemo.Blazor.Server;

[DependsOn(
    typeof(UnifiedDemoBlazorModule)
)]
public class UnifiedDemoBlazorServerModule : AbpModule
{

}
