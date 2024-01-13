using System.ComponentModel.DataAnnotations;

namespace MiradorWebAPI.ViewModels
{
    public class RegisterViewModel
    {
        [Required,EmailAddress]
        public string UserEmail { get; set; }
        [Required]
        public string Password { get; set; }
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
