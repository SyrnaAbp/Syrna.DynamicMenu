using Volo.Abp.Modularity;

namespace Syrna.DynamicMenu.UnifiedDemo.Blazor.WebAssembly;

[DependsOn(
    typeof(DemoBlazorModule)
)]
public class DemoBlazorWebAssemblyModule : AbpModule
{
}
