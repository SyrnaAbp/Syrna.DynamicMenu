using Volo.Abp.Modularity;

namespace Syrna.DynamicMenu.Demo.Blazor.Server;

[DependsOn(
    typeof(DemoBlazorModule)
)]
public class DemoBlazorServerModule : AbpModule
{

}
