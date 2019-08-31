using System.Threading.Tasks;
using IS.Configuration.Dto;

namespace IS.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}