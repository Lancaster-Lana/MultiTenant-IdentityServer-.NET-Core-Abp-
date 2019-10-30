using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using IS.Configuration;
using IS.Configuration.Dto;

namespace IS.Application.Configuration
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
