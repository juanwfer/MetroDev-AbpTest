using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MetroDev.Boilerplate.Authorization.Roles;
using MetroDev.Boilerplate.Authorization.Users;
using MetroDev.Boilerplate.MultiTenancy;

namespace MetroDev.Boilerplate.EntityFrameworkCore
{
    public class BoilerplateDbContext : AbpZeroDbContext<Tenant, Role, User, BoilerplateDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public BoilerplateDbContext(DbContextOptions<BoilerplateDbContext> options)
            : base(options)
        {
        }
    }
}
