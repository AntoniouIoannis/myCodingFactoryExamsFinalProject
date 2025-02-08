namespace CultureGR_MVC_ModelFirst.Data
{
    public class Monument : BaseEntity
    {
        public int Id { get; set; } //Not manipulated by us. It take efect from the DB
        public string monumentName { get; set; } = null!;   // NOT nullable 
        public string monumentDesc { get; set; } = null!;
        public string monumentLocation { get; set; } = null!;
        public string monumentEra { get; set; } = null!;


        public int UserId { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<Monument> Monuments { get; set; } = new HashSet<Monument>();
    }
}
