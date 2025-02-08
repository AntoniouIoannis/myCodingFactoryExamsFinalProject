using CultureGR_MVC_ModelFirst.Data;

namespace CultureGR_MVC_ModelFirst.Repositories
{
    public interface IUserRepository
    {
        Task<User?> GetUserAsync(string username, string password);
        Task<User?> UpdateUserAsync(int id, User userDTO);
        Task<User?> GetByUsernameAsync(string username);
        Task<List<User>> GetAllUsersFilteredPaginatedAsync(int pageNumber, int pageSize,
            List<Func<User, bool>> predicates);
    }
}
