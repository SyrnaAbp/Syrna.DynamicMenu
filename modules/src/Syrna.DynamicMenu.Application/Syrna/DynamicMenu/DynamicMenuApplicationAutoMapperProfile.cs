using Syrna.DynamicMenu.MenuItems;
using Syrna.DynamicMenu.MenuItems.Dtos;
using AutoMapper;
using Volo.Abp.AutoMapper;

namespace Syrna.DynamicMenu
{
    public class DynamicMenuApplicationAutoMapperProfile : Profile
    {
        public DynamicMenuApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<MenuItem, MenuItemDto>().MapExtraProperties();
            CreateMap<CreateMenuItemDto, MenuItem>(MemberList.Source).MapExtraProperties();
            CreateMap<UpdateMenuItemDto, MenuItem>(MemberList.Source).MapExtraProperties();
            CreateMap<MenuItemDto, UpdateMenuItemDto>();
            CreateMap<MenuItemDto, MenuItemViewModel>();
        }
    }
}
