using MetroDev.Boilerplate.Equipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDev.Boilerplate.EntityFrameworkCore.Seed.Host {
    public class InitialEquiposCreator {
        private readonly BoilerplateDbContext _context;

        public InitialEquiposCreator(BoilerplateDbContext context) {
            _context = context;
        }

        public void Create() {
            Categoria primera = _context.Categorias.FirstOrDefault(c => c.Numero == 1);
            Categoria primeraNacional = _context.Categorias.FirstOrDefault(c => c.Numero == 2);

            if (primera == null) {
                primera = new Categoria() {
                    Nombre = "Primera",
                    Numero = 1
                };

                _context.Categorias.Add(primera);
            }

            if (primeraNacional == null) {
                primeraNacional = new Categoria() {
                    Nombre = "Primera Nacional",
                    Numero = 2
                };

                _context.Categorias.Add(primeraNacional);
            }

            var boca = _context.Equipos.FirstOrDefault(e => e.Nombre == "Boca Juniors");
            var river = _context.Equipos.FirstOrDefault(e => e.Nombre == "River Plate");

            if (boca == null) {
                _context.Equipos.Add(new Equipo() {
                    Nombre = "Boca Juniors",
                    Categoria = primera
                });
            }

            if (river == null) {
                _context.Equipos.Add(new Equipo() {
                    Nombre = "River Plate",
                    Categoria = primera
                });
            }

        }
    }
}
