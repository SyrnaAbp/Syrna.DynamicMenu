using Syrna.DynamicMenu.UnifiedDemo.Localization;
using Volo.Abp.Application.Services;

namespace Syrna.DynamicMenu.UnifiedDemo.SettingManagement;

public abstract class SettingManagementAppServiceBase : ApplicationService
{
    protected SettingManagementAppServiceBase()
    {
        ObjectMapperContext = typeof(DemoApplicationModule);
        LocalizationResource = typeof(DemoResource);
    }
}
