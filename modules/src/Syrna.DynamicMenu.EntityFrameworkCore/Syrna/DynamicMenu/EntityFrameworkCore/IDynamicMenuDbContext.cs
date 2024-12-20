using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Syrna.DynamicMenu.MenuItems;

namespace Syrna.DynamicMenu.EntityFrameworkCore
{
    [ConnectionStringName(DynamicMenuDbProperties.ConnectionStringName)]
    public interface IDynamicMenuDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; set; }
         */
        DbSet<MenuItem> MenuItems { get; set; }
    }
}
