﻿using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace Syrna.DynamicMenu
{
    [DependsOn(
        typeof(DynamicMenuDomainModule),
        typeof(DynamicMenuApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class DynamicMenuApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<DynamicMenuApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<DynamicMenuApplicationModule>(validate: false); // todo: https://github.com/abpframework/abp/issues/15404
            });
        }
    }
}
