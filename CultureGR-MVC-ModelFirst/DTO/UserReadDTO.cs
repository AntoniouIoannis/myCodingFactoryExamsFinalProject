namespace CultureGR_MVC_ModelFirst.DTO
{
    public class UserReadDTO : UserBaseDTO
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }

        public UserReadDTO() { }

        public UserReadDTO(string? lastname)
        {

            Lastname = lastname;
        }
    }
}
