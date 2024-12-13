using Volo.Abp.Modularity;

namespace Syrna.DynamicMenu.UnifiedDemo.Blazor.WebAssembly;

[DependsOn(
    typeof(UnifiedDemoBlazorModule)
)]
public class UnifiedDemoBlazorWebAssemblyModule : AbpModule
{
}
