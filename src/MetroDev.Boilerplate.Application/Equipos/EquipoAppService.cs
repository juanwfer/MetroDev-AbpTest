using Abp.Application.Services.Dto;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.Linq.Extensions;
using MetroDev.Boilerplate.Equipos.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDev.Boilerplate.Equipos {
    public class EquipoAppService : BoilerplateAppServiceBase, IEquipoAppService {
        private readonly IRepository<Equipo> _equiposRepository;

        public EquipoAppService(IRepository<Equipo> equipoRepository) {
            _equiposRepository = equipoRepository;
        }

        public ListResultDto<EquipoListDto> GetEquipos(GetEquiposInput input) {
            var equipos = _equiposRepository
                .GetAll()
                .Include(e => e.Categoria)
                .WhereIf(!input.Filtro.IsNullOrEmpty(),
                e => e.Nombre.ToLower().Contains(input.Filtro.ToLower()))
                .OrderBy(p => p.Nombre)
                .ThenBy(p => p.Categoria)
                .ToList();

            return new ListResultDto<EquipoListDto>(ObjectMapper.Map<List<EquipoListDto>>(equipos));
        }
    }
}
