using System.ComponentModel.DataAnnotations;
using CultureGR_MVC_ModelFirst.Core;

namespace CultureGR_MVC_ModelFirst.DTO
{
    public class SubscriberSignupDTO
    {

        // Only for Web Viewers to Registarte to site
        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Identify yourself on this site please.")]
        public string? Identify { get; set; }

        // Only for Web Viewers to Registarte to site
        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Username must be between 2 and 50 characters.")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(100, ErrorMessage = "Email must not exceed 100 characters.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        [RegularExpression(@"(?=.*?[A-Z])(?=.*?[a-z])(?=.*?\d)(?=.*?\W)^.{8,}$",
            ErrorMessage = "Password must contain at least one uppercase, one lowercase, " +
            "one digit, and one special character")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        [RegularExpression(@"(?=.*?[A-Z])(?=.*?[a-z])(?=.*?\d)(?=.*?\W)^.{8,}$",
            ErrorMessage = "Enter Password Again." +
            "must be the same as you give it before, " +
            "one digit, and one special character")]
        public string? RePassword { get; set; }     //Enter psw again

        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Firstname must be between 2 and 50 characters.")]
        public string? Firstname { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Lastname must be between 2 and 50 characters.")]
        public string? Lastname { get; set; }

        // Not needed to complete this fieldd for Registration the Web Viewer
        //[Required(ErrorMessage = "The {0} field is required.")]
        //[StringLength(15, MinimumLength = 10, ErrorMessage = "Phone number must be at least 10 characters and not exceed 15 characters.")]
        //public string? WorkPhoneNumber { get; set; }    //completed only for the Member of Editorial Team

        //[Required(ErrorMessage = "The {0} field is required.")]
        //[StringLength(100, MinimumLength = 2, ErrorMessage = "Institution must be between 2 and 50 characters.")]
        //public string? EditoriaTeam { get; set; }       //completed only for the Member of Editorial Team

        [Required(ErrorMessage = "The {0} field is required.")]
        [EnumDataType(typeof(UserRole), ErrorMessage = "Invalid user role")]
        public UserRole? UserRole { get; set; }     //Reader must be the User Role
    }
}
