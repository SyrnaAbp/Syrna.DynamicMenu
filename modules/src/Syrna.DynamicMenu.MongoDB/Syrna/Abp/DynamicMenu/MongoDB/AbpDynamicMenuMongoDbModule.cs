using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace Syrna.DynamicMenu.MongoDB
{
    [DependsOn(
        typeof(AbpDynamicMenuDomainModule),
        typeof(AbpMongoDbModule)
        )]
    public class AbpDynamicMenuMongoDbModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddMongoDbContext<DynamicMenuMongoDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
            });
        }
    }
}
