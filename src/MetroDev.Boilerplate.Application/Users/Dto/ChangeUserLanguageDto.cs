using System.ComponentModel.DataAnnotations;

namespace MetroDev.Boilerplate.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}