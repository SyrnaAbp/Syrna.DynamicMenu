using Syrna.DynamicMenu.UnifiedDemo.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Syrna.DynamicMenu.UnifiedDemo.Blazor.Server.Host
{
    public abstract class UnifiedDemoComponentBase : AbpComponentBase
    {
        protected UnifiedDemoComponentBase()
        {
            LocalizationResource = typeof(UnifiedDemoResource);
        }
    }
}
