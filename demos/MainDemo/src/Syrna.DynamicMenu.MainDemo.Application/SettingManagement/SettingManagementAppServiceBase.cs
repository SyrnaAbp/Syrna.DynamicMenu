using Syrna.DynamicMenu.MainDemo.Localization;
using Volo.Abp.Application.Services;

namespace Syrna.DynamicMenu.MainDemo.SettingManagement;

public abstract class SettingManagementAppServiceBase : ApplicationService
{
    protected SettingManagementAppServiceBase()
    {
        ObjectMapperContext = typeof(MainDemoApplicationModule);
        LocalizationResource = typeof(MainDemoResource);
    }
}
