﻿using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;
using Volo.Abp.Uow;

namespace Syrna.DynamicMenu.MongoDB
{
    [DependsOn(
        typeof(DynamicMenuTestBaseModule),
        typeof(DynamicMenuMongoDbModule)
        )]
    public class DynamicMenuMongoDbTestModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpDbConnectionOptions>(options =>
            {
                options.ConnectionStrings.Default = MongoDbFixture.GetRandomConnectionString();
            });
        }
    }
}
