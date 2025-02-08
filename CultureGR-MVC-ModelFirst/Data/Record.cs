namespace CultureGR_MVC_ModelFirst.Data
{
    public class Record : BaseEntity
    {
        public int Id { get; set; }
        public string Descr { get; set; } = null!;

        public virtual ICollection<User> Users { get; set; } = new HashSet<User>();
    }
}
