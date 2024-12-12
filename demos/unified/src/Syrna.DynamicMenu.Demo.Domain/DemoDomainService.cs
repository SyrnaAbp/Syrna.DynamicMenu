using Volo.Abp.Domain.Services;
using Volo.Abp.Users;

namespace Syrna.DynamicMenu.Demo
{
    public abstract class DemoDomainService : DomainService
    {
        protected ICurrentUser CurrentUser => LazyServiceProvider.LazyGetRequiredService<ICurrentUser>();
    }
}