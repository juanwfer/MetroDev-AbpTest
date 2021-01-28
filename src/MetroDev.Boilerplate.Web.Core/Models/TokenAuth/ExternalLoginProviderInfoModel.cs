using Abp.AutoMapper;
using MetroDev.Boilerplate.Authentication.External;

namespace MetroDev.Boilerplate.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
