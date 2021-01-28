using Abp.Application.Services.Dto;

namespace MetroDev.Boilerplate.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

