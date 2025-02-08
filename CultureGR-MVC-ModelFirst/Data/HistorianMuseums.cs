using CultureGR_MVC_ModelFirst.Core;

namespace CultureGR_MVC_ModelFirst.Data
{
    public class HistorianMuseums : BaseEntity
    {
        public int Id { get; set; }
        public Idenity EditorialTeam { get; set; }   //   Museums
        public string Username { get; set; } = null!;
        public string WorkPhoneNumber { get; set; } = null!;
        public int UserId { get; set; }     //this is the FK of the user  Owner.

        public virtual User User { get; set; } = null!;
        public virtual ICollection<Record> Records { get; set; } = new HashSet<Record>();
    }
}
