using Syrna.DynamicMenu.MainDemo.Localization;
using Syrna.DynamicMenu.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Syrna.DynamicMenu.MainDemo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MainDemoController : AbpControllerBase
{
    protected MainDemoController()
    {
        LocalizationResource = typeof(MainDemoResource);
    }
}
