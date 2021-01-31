namespace MetroDev.Boilerplate.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly BoilerplateDbContext _context;

        public InitialHostDbBuilder(BoilerplateDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            //new InitialCategoriasCreator(_context).Create();
            new InitialEquiposCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
