using Syrna.DynamicMenu.MenuItems.Dtos;
using AutoMapper;
using Volo.Abp.AutoMapper;
using Syrna.DynamicMenu.Web.Pages.DynamicMenu.MenuItems.MenuItem.ViewModels;

namespace Syrna.DynamicMenu.Web
{
    public class DynamicMenuWebAutoMapperProfile : Profile
    {
        public DynamicMenuWebAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<MenuItemDto, EditMenuItemViewModel>();
            CreateMap<CreateMenuItemViewModel, CreateMenuItemDto>().Ignore(x => x.ExtraProperties);
            CreateMap<EditMenuItemViewModel, UpdateMenuItemDto>().Ignore(x => x.ExtraProperties);
        }
    }
}
