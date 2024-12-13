using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Syrna.DynamicMenu.UnifiedDemo.SettingManagement;

public interface IDemoSettingsAppService : IApplicationService
{
    Task<DemoSettingsDto> GetAsync();

    Task UpdateAsync(UpdateDemoSettingsDto input);
}
