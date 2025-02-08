using CultureGR_MVC_ModelFirst.Core;
using CultureGR_MVC_ModelFirst.Data;
using Microsoft.EntityFrameworkCore;

namespace CultureGR_MVC_ModelFirst.Repositories
{
    public class SubscriberRepository : BaseRepository<Subscriber>, ISubscriberRepository
    {
        public SubscriberRepository(CultureGRDBContext context)
            : base(context)
        {
        }

        public async Task<Subscriber?> GetByUsername(string? username)
        {
            return await context.Subscribers
                .Where(s => s.Username == username)
                .SingleOrDefaultAsync();
        }

        public async Task<List<Record>> GetSubscriberRecordsAsync(int id)
        {
            return await context.Subscribers
                .Where(s => s.Id == id)
                .SelectMany(s => s.Records)
                .ToListAsync();
        }

        public async Task<List<User>> GetAllUsersSubscribersAsync()
        {
            return await context.Users
                .Where(u => u.UserRole == UserRole.Reader)
                .Include(u => u.Subscriber)
                .ToListAsync();
        }

        public Task<Subscriber?> GetByFirstname(string? Firstname)
        {
            throw new NotImplementedException();
        }

        public Task<Subscriber?> GetByLastname(string? Lastname)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAllUsersSubscriberAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Record>> GetStudentCoursesAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAllUsersStudentsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
