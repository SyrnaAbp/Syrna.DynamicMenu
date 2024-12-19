using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Syrna.DynamicMenu
{
    [DependsOn(
        typeof(DynamicMenuHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class DynamicMenuConsoleApiClientModule : AbpModule
    {
        
    }
}
