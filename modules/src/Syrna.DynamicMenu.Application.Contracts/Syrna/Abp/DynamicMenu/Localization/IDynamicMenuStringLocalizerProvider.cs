using System;
using System.Threading.Tasks;
using Syrna.DynamicMenu.MenuItems.Dtos;
using Microsoft.Extensions.Localization;

namespace Syrna.DynamicMenu.Localization
{
    public interface IDynamicMenuStringLocalizerProvider
    {
        Task<IStringLocalizer> GetAsync(MenuItemDto menuItem);
        
        Task<string> GetResourceNameAsync(MenuItemDto menuItem);

        Task<Type> GetResourceTypeOrNullAsync(MenuItemDto menuItem);
    }
}