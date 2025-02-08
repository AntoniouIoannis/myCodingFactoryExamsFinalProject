namespace CultureGR_MVC_ModelFirst.DTO
{
    public class RecordUpdateDTO : RecordBaseDTO
    {
        public string? Desc { get; set; }

        public RecordUpdateDTO() { }

        public RecordUpdateDTO(string? desc)
        {
            Desc = desc;
        }
    }
}
