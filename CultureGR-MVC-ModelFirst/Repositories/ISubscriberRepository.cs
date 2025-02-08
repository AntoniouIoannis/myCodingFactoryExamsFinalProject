using CultureGR_MVC_ModelFirst.Data;

namespace CultureGR_MVC_ModelFirst.Repositories
{
    public interface ISubscriberRepository
    {
        Task<List<Record>> GetStudentCoursesAsync(int id);
        Task<Subscriber?> GetByUsername(string? Username);
        Task<Subscriber?> GetByFirstname(string? Firstname);
        Task<Subscriber?> GetByLastname(string? Lastname);
        Task<List<User>> GetAllUsersStudentsAsync();
    }
}
