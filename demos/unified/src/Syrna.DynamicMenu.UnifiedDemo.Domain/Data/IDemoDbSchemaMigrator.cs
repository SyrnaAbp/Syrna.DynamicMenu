using System.Threading.Tasks;

namespace Syrna.DynamicMenu.UnifiedDemo.Data;

public interface IDemoDbSchemaMigrator
{
    Task MigrateAsync();
}
