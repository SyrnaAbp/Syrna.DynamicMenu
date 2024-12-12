using Syrna.DynamicMenu.Demo.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Syrna.DynamicMenu.Demo.Blazor.Server.Host
{
    public abstract class DynamicMenuDemoComponentBase : AbpComponentBase
    {
        protected DynamicMenuDemoComponentBase()
        {
            LocalizationResource = typeof(DemoResource);
        }
    }
}
