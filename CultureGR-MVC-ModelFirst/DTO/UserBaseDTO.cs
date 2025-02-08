using System.ComponentModel.DataAnnotations;

namespace CultureGR_MVC_ModelFirst.DTO
{
    // abstrract class for extened the DTOs for Users 
    public abstract class UserBaseDTO
    {
        [Required(ErrorMessage = "The {0} is required.")]
        public int Id { get; set; }

        public UserBaseDTO() { }

        protected UserBaseDTO(int id)
        {
            Id = id;
        }
    }
}
