using System.ComponentModel.DataAnnotations;

namespace CultureGR_MVC_ModelFirst.DTO
{
    public class RecordInsertDTO : RecordBaseDTO
    {
        [Required(ErrorMessage = "Description is required.")]
        [MinLength(1, ErrorMessage = "Description must be at least 50 character long.")]
        public string? Desc { get; set; }



        public RecordInsertDTO() { }

        public RecordInsertDTO(string? desc)
        {
            Desc = desc;
        }
    }
}
