using Volo.Abp.Modularity;

namespace Syrna.DynamicMenu.MainDemo.Blazor.Server;

[DependsOn(
    typeof(MainDemoBlazorModule)
)]
public class MainDemoBlazorServerModule : AbpModule
{

}
