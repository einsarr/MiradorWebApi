using System.ComponentModel.DataAnnotations;

namespace MiradorWebAPI.ViewModels
{
    public class LoginViewModel
    {
        [Required, EmailAddress]
        public string UserEmail { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
