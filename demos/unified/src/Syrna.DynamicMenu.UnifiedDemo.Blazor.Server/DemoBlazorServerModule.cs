using Volo.Abp.Modularity;

namespace Syrna.DynamicMenu.UnifiedDemo.Blazor.Server;

[DependsOn(
    typeof(DemoBlazorModule)
)]
public class DemoBlazorServerModule : AbpModule
{

}
