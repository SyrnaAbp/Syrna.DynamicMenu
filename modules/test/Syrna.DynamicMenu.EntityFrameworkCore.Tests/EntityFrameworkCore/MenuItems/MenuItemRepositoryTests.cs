using System;
using System.Threading.Tasks;
using Syrna.DynamicMenu.MenuItems;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Syrna.DynamicMenu.EntityFrameworkCore.MenuItems
{
    public class MenuItemRepositoryTests : DynamicMenuEntityFrameworkCoreTestBase
    {
        private readonly IMenuItemRepository _menuItemRepository;

        public MenuItemRepositoryTests()
        {
            _menuItemRepository = GetRequiredService<IMenuItemRepository>();
        }

        /*
        [Fact]
        public async Task Test1()
        {
            await WithUnitOfWorkAsync(async () =>
            {
                // Arrange

                // Act

                //Assert
            });
        }
        */
    }
}
