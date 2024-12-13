using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.DependencyInjection;
using System.Threading.Tasks;
using System;
using Syrna.DynamicMenu.UnifiedDemo.Data;

namespace Syrna.DynamicMenu.UnifiedDemo.SqlServer.EntityFrameworkCore;

public class EntityFrameworkCoreDemoDbSchemaMigrator(
    IServiceProvider serviceProvider)
        : IDemoDbSchemaMigrator, ITransientDependency
{
    public async Task MigrateAsync()
    {
        /* We intentionally resolving the LayoutMigrationsDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await serviceProvider
            .GetRequiredService<DemoMigrationsDbContext>()
            .Database
            .MigrateAsync();
    }
}