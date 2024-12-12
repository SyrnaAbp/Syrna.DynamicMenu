using System.Threading.Tasks;

namespace Syrna.DynamicMenu.Demo.Data;

public interface IDemoDbSchemaMigrator
{
    Task MigrateAsync();
}
