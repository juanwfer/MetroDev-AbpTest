using Abp.Application.Services.Dto;
using MetroDev.Boilerplate.Equipos.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDev.Boilerplate.Equipos {
    public interface IEquipoAppService {
        ListResultDto<EquipoListDto> GetEquipos(GetEquiposInput input);
    }
}
