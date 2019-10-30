using System.Threading.Tasks;
using IS.Configuration.Dto;

namespace IS.Application.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}