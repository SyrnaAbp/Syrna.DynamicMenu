using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Syrna.DynamicMenu.MenuItems;

namespace Syrna.DynamicMenu.EntityFrameworkCore
{
    [ConnectionStringName(DynamicMenuDbProperties.ConnectionStringName)]
    public class DynamicMenuDbContext : AbpDbContext<DynamicMenuDbContext>, IDynamicMenuDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */
        public DbSet<MenuItem> MenuItems { get; set; }

        public DynamicMenuDbContext(DbContextOptions<DynamicMenuDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureDynamicMenu();
        }
    }
}
