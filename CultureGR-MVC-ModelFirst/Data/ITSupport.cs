namespace CultureGR_MVC_ModelFirst.Data
{
    public class ITSupport : BaseEntity
    {
        // Not Belong to a EditorialTeam 
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string WorkPhoneNumber { get; set; } = null!;
        public int UserId { get; set; }     //this is the FK of the user  itsupport 

        public virtual User User { get; set; } = null!;
        public virtual ICollection<Record> Records { get; set; } = new HashSet<Record>();
    }
}
