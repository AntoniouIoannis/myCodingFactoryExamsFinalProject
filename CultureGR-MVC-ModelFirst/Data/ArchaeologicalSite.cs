namespace CultureGR_MVC_ModelFirst.Data
{
    public class ArchaeologicalSite : BaseEntity
    {
        public int Id { get; set; }
        public required string Region { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public string Location { get; set; } = null!;


        public virtual User User { get; set; } = null!;

    }
}
