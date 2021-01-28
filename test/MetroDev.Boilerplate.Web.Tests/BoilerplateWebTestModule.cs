using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MetroDev.Boilerplate.EntityFrameworkCore;
using MetroDev.Boilerplate.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace MetroDev.Boilerplate.Web.Tests
{
    [DependsOn(
        typeof(BoilerplateWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class BoilerplateWebTestModule : AbpModule
    {
        public BoilerplateWebTestModule(BoilerplateEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BoilerplateWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(BoilerplateWebMvcModule).Assembly);
        }
    }
}