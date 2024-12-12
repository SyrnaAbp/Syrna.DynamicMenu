using Syrna.DynamicMenu.Demo.Localization;
using Volo.Abp.Application.Services;

namespace Syrna.DynamicMenu.Demo.SettingManagement;

public abstract class SettingManagementAppServiceBase : ApplicationService
{
    protected SettingManagementAppServiceBase()
    {
        ObjectMapperContext = typeof(DemoApplicationModule);
        LocalizationResource = typeof(DemoResource);
    }
}
