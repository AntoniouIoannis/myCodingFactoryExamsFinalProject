namespace CultureGR_MVC_ModelFirst.Data
{
    public class Excavation : BaseEntity
    {
        public int Id { get; set; }
        public int Region { get; set; }
        public string Description { get; set; } = null!;


        public virtual User User { get; set; } = null!;
        public virtual ICollection<Record> Records { get; set; } = new HashSet<Record>();
    }
}
