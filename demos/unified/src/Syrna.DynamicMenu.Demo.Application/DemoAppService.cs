using Syrna.DynamicMenu.Demo.Localization;
using Volo.Abp.Application.Services;

namespace Syrna.DynamicMenu.Demo;

/* Inherit your application services from this class.
 */
public abstract class DemoAppService : ApplicationService
{
    protected DemoAppService()
    {
        LocalizationResource = typeof(DemoResource);
    }
}
