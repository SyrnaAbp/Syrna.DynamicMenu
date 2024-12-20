﻿using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Syrna.DynamicMenu.EntityFrameworkCore
{
    public class DynamicMenuModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public DynamicMenuModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}