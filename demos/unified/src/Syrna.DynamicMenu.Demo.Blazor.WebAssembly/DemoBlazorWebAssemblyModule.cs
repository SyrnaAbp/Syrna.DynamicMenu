using Volo.Abp.Modularity;

namespace Syrna.DynamicMenu.Demo.Blazor.WebAssembly;

[DependsOn(
    typeof(DemoBlazorModule)
)]
public class DemoBlazorWebAssemblyModule : AbpModule
{
}
