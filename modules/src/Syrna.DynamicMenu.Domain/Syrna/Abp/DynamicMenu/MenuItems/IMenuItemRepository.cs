using System;
using Volo.Abp.Domain.Repositories;

namespace Syrna.DynamicMenu.MenuItems
{
    public interface IMenuItemRepository : IRepository<MenuItem>
    {
    }
}