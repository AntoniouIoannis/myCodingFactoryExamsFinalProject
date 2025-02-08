namespace CultureGR_MVC_ModelFirst.Data
{
    public class TextEditor
    {
        // Belong to all EditorialTeam one to many
        public int Id { get; set; }
        public string ΕditorialΤeam { get; set; } = null!;   // E
        public string Username { get; set; } = null!;
        public string WorkPhoneNumber { get; set; } = null!;
        public int UserId { get; set; }     //this is the FK of the user  Owner. 

        public virtual User User { get; set; } = null!;
        public virtual ICollection<Record> Records { get; set; } = new HashSet<Record>();
    }
}
