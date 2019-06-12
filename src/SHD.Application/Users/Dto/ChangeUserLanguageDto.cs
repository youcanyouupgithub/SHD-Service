using System.ComponentModel.DataAnnotations;

namespace SHD.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}