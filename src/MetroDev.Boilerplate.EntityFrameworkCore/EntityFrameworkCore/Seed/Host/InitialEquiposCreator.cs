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

        private Categoria AgregarCategoriaSiFalta(Categoria categoria, int numero, string nombre) {
            if (categoria == null) {
                categoria = new Categoria() {
                    Nombre = nombre,
                    Numero = numero
                };

                _context.Categorias.Add(categoria);
            }

            return categoria;
        }

        public void Create() {
            Categoria primera = _context.Categorias.FirstOrDefault(c => c.Numero == 1);
            Categoria primeraNacional = _context.Categorias.FirstOrDefault(c => c.Numero == 2);

            Categoria primeraB = _context.Categorias.FirstOrDefault(c => c.Numero == 3 && c.Nombre == "Primera B");
            Categoria primeraC = _context.Categorias.FirstOrDefault(c => c.Numero == 4 && c.Nombre == "Primera C");
            Categoria primeraD = _context.Categorias.FirstOrDefault(c => c.Numero == 5 && c.Nombre == "Primera D");

            Categoria torneoFederalA = _context.Categorias.FirstOrDefault(c => c.Numero == 3 && c.Nombre == "Torneo Feredal A");
            Categoria torneoFederalRegionalAmateur = _context.Categorias.FirstOrDefault(c => c.Numero == 4 && c.Nombre == "Torneo Federal Regional Amateur");
            Categoria ligasRegionales = _context.Categorias.FirstOrDefault(c => c.Numero == 5 && c.Nombre == "Ligas Nacionales");

            primera = AgregarCategoriaSiFalta(primera, 1, "Primera");
            primeraNacional = AgregarCategoriaSiFalta(primeraNacional, 2, "Primera Nacional");

            primeraB = AgregarCategoriaSiFalta(primeraB, 3, "Primera B");
            primeraC = AgregarCategoriaSiFalta(primeraC, 4, "Primera C");
            primeraD = AgregarCategoriaSiFalta(primeraD, 5, "Primera D");

            torneoFederalA = AgregarCategoriaSiFalta(torneoFederalA, 3, "Torneo Federal A");
            torneoFederalRegionalAmateur = AgregarCategoriaSiFalta(torneoFederalRegionalAmateur, 4, "Torneo Federal Regional Amateur");
            ligasRegionales = AgregarCategoriaSiFalta(ligasRegionales, 5, "Ligas Regionales");

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
