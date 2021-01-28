using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MetroDev.Boilerplate.Configuration.Dto;

namespace MetroDev.Boilerplate.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : BoilerplateAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
