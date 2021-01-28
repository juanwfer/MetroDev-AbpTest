using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MetroDev.Boilerplate.Configuration;

namespace MetroDev.Boilerplate.Web.Host.Startup
{
    [DependsOn(
       typeof(BoilerplateWebCoreModule))]
    public class BoilerplateWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public BoilerplateWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BoilerplateWebHostModule).GetAssembly());
        }
    }
}
