using Syrna.DynamicMenu.UnifiedDemo.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Syrna.DynamicMenu.UnifiedDemo.Blazor.Server.Host
{
    public abstract class DynamicMenuDemoComponentBase : AbpComponentBase
    {
        protected DynamicMenuDemoComponentBase()
        {
            LocalizationResource = typeof(DemoResource);
        }
    }
}
