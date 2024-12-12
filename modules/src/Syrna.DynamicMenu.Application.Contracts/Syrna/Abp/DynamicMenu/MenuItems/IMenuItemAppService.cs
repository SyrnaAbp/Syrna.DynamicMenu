using System;
using System.Threading.Tasks;
using Syrna.DynamicMenu.MenuItems.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using static Syrna.DynamicMenu.Permissions.DynamicMenuPermissions;

namespace Syrna.DynamicMenu.MenuItems
{
    public interface IMenuItemAppService :
        ICrudAppService<
            MenuItemDto,
            MenuItemDto,
            string,
            GetMenuItemListInput,
            CreateMenuItemDto,
            UpdateMenuItemDto>
    {
    }
}