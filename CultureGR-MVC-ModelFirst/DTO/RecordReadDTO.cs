namespace CultureGR_MVC_ModelFirst.DTO
{
    public class RecordReadDTO : RecordBaseDTO
    {
        public string? Desc { get; set; }

        public RecordReadDTO() { }

        public RecordReadDTO(string? desc)
        {
            Desc = desc;
        }
    }
}
