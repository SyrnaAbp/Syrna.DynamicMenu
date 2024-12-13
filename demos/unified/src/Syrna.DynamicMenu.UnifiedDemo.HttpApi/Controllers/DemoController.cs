using Syrna.DynamicMenu.UnifiedDemo.Localization;
using Syrna.DynamicMenu.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Syrna.DynamicMenu.UnifiedDemo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class DemoController : AbpControllerBase
{
    protected DemoController()
    {
        LocalizationResource = typeof(DemoResource);
    }
}
