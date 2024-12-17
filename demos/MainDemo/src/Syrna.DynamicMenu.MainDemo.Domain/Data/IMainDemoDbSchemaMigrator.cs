using System.Threading.Tasks;

namespace Syrna.DynamicMenu.MainDemo.Data;

public interface IMainDemoDbSchemaMigrator
{
    Task MigrateAsync();
}
