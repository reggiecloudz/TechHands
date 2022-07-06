using System.ComponentModel.DataAnnotations;

namespace TechHands.Api.Data.DTO
{
    public class LoginDTO
    {
        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }
    }
}