﻿using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Syrna.DynamicMenu.MongoDB
{
    [ConnectionStringName(DynamicMenuDbProperties.ConnectionStringName)]
    public interface IDynamicMenuMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; set; }
         */
    }
}
