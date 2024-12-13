using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Syrna.DynamicMenu.EntityFrameworkCore;

public class UnifiedDemoModelBuilderConfigurationOptions(
   [NotNull] string tablePrefix = "",
   [CanBeNull] string schema = null) : AbpModelBuilderConfigurationOptions(
       tablePrefix,
       schema)
{
}
