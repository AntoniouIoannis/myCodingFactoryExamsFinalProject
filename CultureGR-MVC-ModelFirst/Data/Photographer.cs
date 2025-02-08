namespace CultureGR_MVC_ModelFirst.Data
{
    public class Photographer
    {
        public int Id { get; set; }
        //every phptographeer will belongs to all editorial teams  many to many
        public string ΕditorialΤeam { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string WorkPhoneNumber { get; set; } = null!;
        public int UserId { get; set; }     //this is the FK of the user  Owner. 

        public virtual User User { get; set; } = null!;
        public virtual ICollection<Record> Records { get; set; } = new HashSet<Record>();
    }
}
