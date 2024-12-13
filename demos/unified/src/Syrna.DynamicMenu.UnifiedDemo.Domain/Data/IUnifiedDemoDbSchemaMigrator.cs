using System.Threading.Tasks;

namespace Syrna.DynamicMenu.UnifiedDemo.Data;

public interface IUnifiedDemoDbSchemaMigrator
{
    Task MigrateAsync();
}
