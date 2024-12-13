using Syrna.DynamicMenu.UnifiedDemo.Localization;
using Volo.Abp.Application.Services;

namespace Syrna.DynamicMenu.UnifiedDemo;

/* Inherit your application services from this class.
 */
public abstract class DemoAppService : ApplicationService
{
    protected DemoAppService()
    {
        LocalizationResource = typeof(DemoResource);
    }
}
