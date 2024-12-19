using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Syrna.DynamicMenu.MenuItems;
using Syrna.DynamicMenu.MenuItems.Dtos;
using Syrna.DynamicMenu.Web.Pages.DynamicMenu.MenuItems.MenuItem.ViewModels;

namespace Syrna.DynamicMenu.Web.Pages.Abp.DynamicMenu.MenuItems.MenuItem
{
    public class EditModalModel : DynamicMenuPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }

        [BindProperty]
        public EditMenuItemViewModel ViewModel { get; set; }

        private readonly IMenuItemAppService _service;

        public EditModalModel(IMenuItemAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<MenuItemDto, EditMenuItemViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<EditMenuItemViewModel, UpdateMenuItemDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}