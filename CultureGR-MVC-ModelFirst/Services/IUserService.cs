using CultureGR_MVC_ModelFirst.Data;
using CultureGR_MVC_ModelFirst.DTO;

namespace CultureGR_MVC_ModelFirst.Services
{
    public interface IUserService
    {
        Task<User?> VerifyAndGetUserAsync(UserLoginDTO credentials);
        Task<User?> GetUserByUsernameAsync(string username);
        Task<List<User>> GetAllUsersFiltered(int pageNumber, int pageSize,
            UserFiltersDTO userFiltersDTO);
    }
}
