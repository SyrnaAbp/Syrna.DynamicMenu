using Syrna.DynamicMenu.Demo.Localization;
using Syrna.DynamicMenu.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Syrna.DynamicMenu.Demo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class DemoController : AbpControllerBase
{
    protected DemoController()
    {
        LocalizationResource = typeof(DemoResource);
    }
}
