using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using IS.Configuration.Dto;

namespace IS.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
