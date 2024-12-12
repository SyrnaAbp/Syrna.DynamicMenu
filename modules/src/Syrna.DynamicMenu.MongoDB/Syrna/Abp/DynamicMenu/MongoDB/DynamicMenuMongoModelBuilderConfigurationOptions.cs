using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Syrna.DynamicMenu.MongoDB
{
    public class DynamicMenuMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public DynamicMenuMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}