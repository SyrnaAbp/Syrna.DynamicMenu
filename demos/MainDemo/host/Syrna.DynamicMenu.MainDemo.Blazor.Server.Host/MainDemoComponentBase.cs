using Syrna.DynamicMenu.MainDemo.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Syrna.DynamicMenu.MainDemo.Blazor.Server.Host
{
    public abstract class MainDemoComponentBase : AbpComponentBase
    {
        protected MainDemoComponentBase()
        {
            LocalizationResource = typeof(MainDemoResource);
        }
    }
}
