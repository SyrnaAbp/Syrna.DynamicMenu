using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Syrna.DynamicMenu.MenuItems;

namespace Syrna.DynamicMenu.EntityFrameworkCore
{
    [ConnectionStringName(DynamicMenuDbProperties.ConnectionStringName)]
    public interface IDemoDbContext : IEfCoreDbContext
    {
    }
}
