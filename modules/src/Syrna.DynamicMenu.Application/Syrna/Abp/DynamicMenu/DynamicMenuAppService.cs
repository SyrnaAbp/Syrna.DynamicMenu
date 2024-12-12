using Syrna.DynamicMenu.Localization;
using Volo.Abp.Application.Services;

namespace Syrna.DynamicMenu
{
    public abstract class DynamicMenuAppService : ApplicationService
    {
        protected DynamicMenuAppService()
        {
            LocalizationResource = typeof(DynamicMenuResource);
            ObjectMapperContext = typeof(AbpDynamicMenuApplicationModule);
        }
    }
}
