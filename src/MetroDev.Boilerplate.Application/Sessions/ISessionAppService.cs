using System.Threading.Tasks;
using Abp.Application.Services;
using MetroDev.Boilerplate.Sessions.Dto;

namespace MetroDev.Boilerplate.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
