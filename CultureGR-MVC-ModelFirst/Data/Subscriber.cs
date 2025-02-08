using CultureGR_MVC_ModelFirst.Core;

namespace CultureGR_MVC_ModelFirst.Data
{
    public class Subscriber : BaseEntity
    {
        // does not belong to EditorialTeam , Do Not must have property enum 'editorialTeam'
        public int Id { get; set; } //Not manipulated by us. It take efect from the DB
        public string Username { get; set; } = null!;   // NOT nullable 
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string RePassword { get; set; } = null!;     // repeat type psw, for the case of wrong typing than the user had his mind
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public bool Banned { get; set; } = false;
        public UserRole UserRole { get; set; }      // **  Read write -only comment & rate 

        public int UserId { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<Record> Records { get; set; } = new HashSet<Record>();
    }
}
