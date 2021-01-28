using System.Threading.Tasks;
using MetroDev.Boilerplate.Configuration.Dto;

namespace MetroDev.Boilerplate.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
