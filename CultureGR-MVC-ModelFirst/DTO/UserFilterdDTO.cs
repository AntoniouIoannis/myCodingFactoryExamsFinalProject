using System.ComponentModel.DataAnnotations;
using CultureGR_MVC_ModelFirst.Core;

namespace CultureGR_MVC_ModelFirst.DTO
{
    public class UserFilterdDTO
    {
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Username must be between 2 and 50 characters.")]
        public string? Username { get; set; }

        [StringLength(50, MinimumLength = 2, ErrorMessage = "Email must be exist.")]
        public string? Email { get; set; }

        [RegularExpression(@"(?=.*?[A-Z])(?=.*?[a-z])(?=.*?\d)(?=.*?\W)^.{8,}$",
            ErrorMessage = "Password must contain at least one uppercase, one lowercase, " +
            "one digit, and one special character")]
        public string? Password { get; set; }


        [StringLength(50, MinimumLength = 2, ErrorMessage = "UserRole must be exist.")]
        public UserRole? UserRole { get; set; }

        public bool KeepLoggedIn { get; set; }








    }
}
