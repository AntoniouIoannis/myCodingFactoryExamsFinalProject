namespace CultureGR_MVC_ModelFirst.Data
{
    public class WebDeveloper : BaseEntity
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string WorkPhoneNumber { get; set; } = null!;
        public int UserId { get; set; }     //this is the FK of the user  *** WebEditor
    }
}
