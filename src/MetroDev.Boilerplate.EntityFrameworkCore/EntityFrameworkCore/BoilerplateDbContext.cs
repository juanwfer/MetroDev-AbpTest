using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MetroDev.Boilerplate.Authorization.Roles;
using MetroDev.Boilerplate.Authorization.Users;
using MetroDev.Boilerplate.MultiTenancy;
using MetroDev.Boilerplate.Equipos;

namespace MetroDev.Boilerplate.EntityFrameworkCore
{
    public class BoilerplateDbContext : AbpZeroDbContext<Tenant, Role, User, BoilerplateDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public virtual DbSet<Equipo> Equipos { get; set; }

        public virtual DbSet<Equipo> Campeonatos { get; set; }

        public virtual DbSet<Equipo> Categorias { get; set; }

        public BoilerplateDbContext(DbContextOptions<BoilerplateDbContext> options)
            : base(options)
        {
        }
    }
}
