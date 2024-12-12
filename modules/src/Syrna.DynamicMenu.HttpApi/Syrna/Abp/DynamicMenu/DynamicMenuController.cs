using Syrna.DynamicMenu.Localization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace Syrna.DynamicMenu
{
    [Area(AbpDynamicMenuRemoteServiceConsts.ModuleName)]
    public abstract class DynamicMenuController : AbpControllerBase
    {
        protected DynamicMenuController()
        {
            LocalizationResource = typeof(DynamicMenuResource);
        }
    }
}
