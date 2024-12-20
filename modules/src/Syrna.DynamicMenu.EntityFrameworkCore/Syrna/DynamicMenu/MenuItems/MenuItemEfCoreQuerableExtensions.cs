using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Syrna.DynamicMenu.MenuItems
{
    public static class MenuItemEfCoreQueryableExtensions
    {
        public static IQueryable<MenuItem> IncludeDetails(this IQueryable<MenuItem> queryable, bool include = true)
        {
            if (!include)
            {
                return queryable;
            }

            return queryable
                .Include(x => x.MenuItems)
                .ThenInclude(x => x.MenuItems);
        }
    }
}