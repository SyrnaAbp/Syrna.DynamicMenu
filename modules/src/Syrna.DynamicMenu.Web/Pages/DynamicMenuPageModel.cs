using Syrna.DynamicMenu.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Syrna.DynamicMenu.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class DynamicMenuPageModel : AbpPageModel
    {
        protected DynamicMenuPageModel()
        {
            LocalizationResourceType = typeof(DynamicMenuResource);
            ObjectMapperContext = typeof(DynamicMenuWebModule);
        }
    }
}