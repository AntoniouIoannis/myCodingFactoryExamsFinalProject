namespace CultureGR_MVC_ModelFirst.Data
{
    public class Owner
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string WorkPhoneNumber { get; set; } = null!;
        public int UserId { get; set; }     //this is the FK of the user  Owner.  
        //public UserRole UserRole { get; set; }      //retrives form enum class each time new user  ** Admin Role
    }
}
