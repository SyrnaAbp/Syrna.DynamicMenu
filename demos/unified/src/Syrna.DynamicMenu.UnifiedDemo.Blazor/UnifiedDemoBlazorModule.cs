using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Threading;
using Volo.Abp.AspNetCore.Components.Web.Theming.Routing;
using Syrna.DynamicMenu.Blazor;
using Volo.Abp.AspNetCore.Components.Web.Theming;

namespace Syrna.DynamicMenu.UnifiedDemo.Blazor;

[DependsOn(typeof(AbpAutoMapperModule))]
[DependsOn(typeof(AbpAspNetCoreComponentsWebThemingModule))]
//app modules
[DependsOn(typeof(UnifiedDemoApplicationContractsModule))]
[DependsOn(typeof(DynamicMenuBlazorModule))]

public class UnifiedDemoBlazorModule : AbpModule
{
    private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<UnifiedDemoBlazorModule>();

        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddProfile<UnifiedDemoBlazorAutoMapperProfile>(validate: true);
        });

        //Configure<AbpNavigationOptions>(options =>
        //{
        //    options.MenuContributors.Add(new DemoMenuContributor());
        //});

        Configure<AbpRouterOptions>(options =>
        {
            options.AdditionalAssemblies.Add(typeof(UnifiedDemoBlazorModule).Assembly);
        });
    }
}
