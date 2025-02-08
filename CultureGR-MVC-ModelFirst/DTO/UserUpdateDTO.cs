namespace CultureGR_MVC_ModelFirst.DTO
{
    public class UserUpdateDTO : UserBaseDTO
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }

        public UserUpdateDTO() { }

        public UserUpdateDTO(string? lastname)
        {

            Lastname = lastname;
        }
    }
}
