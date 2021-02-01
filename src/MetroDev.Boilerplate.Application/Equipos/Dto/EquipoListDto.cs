using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDev.Boilerplate.Equipos.Dto {

    [AutoMapFrom(typeof(Equipo))]
    public class EquipoListDto : EntityDto {
        public string Nombre { get; set; }

        public CategoriaEnEquipoListDto Categoria { get; set; }
    }

    [AutoMapFrom(typeof(Categoria))]
    public class CategoriaEnEquipoListDto : EntityDto {
        public string Nombre { get; set; }

        public int Numero { get; set; }
    }
}
