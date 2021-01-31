using MetroDev.Boilerplate.Equipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDev.Boilerplate.EntityFrameworkCore.Seed.Host {
    public class InitialCategoriasCreator {
        private readonly BoilerplateDbContext _context;

        public InitialCategoriasCreator(BoilerplateDbContext context) {
            _context = context;
        }

        public void Create() {
            var primera = _context.Categorias.FirstOrDefault(c => c.Numero == 1);
            var primeraNacional = _context.Categorias.FirstOrDefault(c => c.Numero == 2);

            if (primera == null) {
                _context.Categorias.Add(new Categoria() {
                    Nombre = "Primera",
                    Numero = 1
                });
            }

            if (primeraNacional == null) {
                _context.Categorias.Add(new Categoria() {
                    Nombre = "Primera Nacional",
                    Numero = 2
                });
            }

        }
    }
}
