using System.ComponentModel.DataAnnotations;

namespace CultureGR_MVC_ModelFirst.DTO
{
    public class UserInsertDTO : RecordBaseDTO
    {
        [Required(ErrorMessage = "Firstname is required.")]
        [MinLength(1, ErrorMessage = "Firstname must be at least 1 character long.")]
        public string? Firstname { get; set; }

        [Required(ErrorMessage = "Lastname is required.")]
        [MinLength(1, ErrorMessage = "Lastname must be at least 1 character long.")]
        public string? Lastname { get; set; }

        public UserInsertDTO() { }

        public UserInsertDTO(string? firstname, string? lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }
    }
}
