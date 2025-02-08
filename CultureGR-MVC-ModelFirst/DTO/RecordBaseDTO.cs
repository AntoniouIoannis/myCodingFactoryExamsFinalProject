using System.ComponentModel.DataAnnotations;

namespace CultureGR_MVC_ModelFirst.DTO
{
    // abstrract class for extened the DTOs for records of Museums, Monuments, culture center, etc records
    public abstract class RecordBaseDTO
    {
        [Required(ErrorMessage = "The {0} is required.")]
        public int Id { get; set; }

        public RecordBaseDTO() { }

        protected RecordBaseDTO(int id)
        {
            Id = id;
        }
    }
}
