using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Syrna.DynamicMenu
{
    [DependsOn(
        typeof(DynamicMenuApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class DynamicMenuHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = DynamicMenuRemoteServiceConsts.RemoteServiceName;

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(DynamicMenuApplicationContractsModule).Assembly,
                RemoteServiceName
            );
            
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<DynamicMenuApplicationContractsModule>();
            });
        }
    }
}
