using Volo.Abp.Modularity;

namespace Syrna.DynamicMenu.MainDemo.Blazor.WebAssembly;

[DependsOn(
    typeof(MainDemoBlazorModule)
)]
public class MainDemoBlazorWebAssemblyModule : AbpModule
{
}
