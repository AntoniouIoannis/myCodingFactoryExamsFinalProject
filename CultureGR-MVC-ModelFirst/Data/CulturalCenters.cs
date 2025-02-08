namespace CultureGR_MVC_ModelFirst.Data
{
    public class CulturaCenters : BaseEntity
    {
        public int Id { get; set; } //Not manipulated by us. It take efect from the DB
        public string mus_region { get; set; } = null!;   // NOT nullable 
        public string mus_name { get; set; } = null!;
        public string mus_desc { get; set; } = null!;
        public string mus_address { get; set; } = null!;     // repeat type psw, for the case of wrong typing than the user had his mind
        public string mus_phone { get; set; } = null!;
       
        public int UserId { get; set; }

      
    }
}
