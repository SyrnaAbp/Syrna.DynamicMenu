using System.Threading.Tasks;
using Syrna.DynamicMenu.MenuItems;
using Syrna.DynamicMenu.MenuItems.Dtos;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Mvc;
using Syrna.DynamicMenu.Web.Pages.DynamicMenu.MenuItems.MenuItem.ViewModels;

namespace Syrna.DynamicMenu.Web.Pages.Abp.DynamicMenu.MenuItems.MenuItem
{
    public class CreateModalModel : DynamicMenuPageModel
    {
        [BindProperty]
        public CreateMenuItemViewModel ViewModel { get; set; } = new();

        private readonly IMenuItemAppService _service;

        public CreateModalModel(IMenuItemAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync([CanBeNull] string parentId)
        {
            ViewModel.ParentId = parentId;
            ViewModel.LResourceTypeName = DynamicMenuConsts.DefaultLResourceTypeName;
            ViewModel.LResourceTypeAssemblyName = DynamicMenuConsts.DefaultLResourceTypeAssemblyName;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateMenuItemViewModel, CreateMenuItemDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}