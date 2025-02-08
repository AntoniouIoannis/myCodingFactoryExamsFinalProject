using CultureGR_MVC_ModelFirst.Core;
using CultureGR_MVC_ModelFirst.Data;
using CultureGR_MVC_ModelFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace CultureGR_MVC_ModelFirst.Repositories
{
    public class WriterArchPlacesRepository : BaseRepository<WriterArchPlaces>, IWriterArchPlacesRepository
    {
        public WriterArchPlacesRepository(CultureGRDBContext context)
            : base(context)
        {
        }

        public async Task<WriterArchPlaces?> GetByWorkPhoneNumberAsync(string? workphoneNumber)
        {
            return await context.writerArchPlaces
                .Where(w => w.WorkPhoneNumber == workphoneNumber)
                .FirstOrDefaultAsync();
        }

        public async Task<List<Record>> GetWriterArchPlacesRecordsAsync(int id)
        {
            List<Record> records;

            records = await context.writerArchPlaces    //list or recordsfrom certain WriterArchPlaces 
                .Where(w => w.Id == id)                 // the specific id 
                .SelectMany(w => w.Records)             // the list of Archaeological Places witch put in the list of Places
                .ToListAsync();                         // make the list!!!!

            return records;
        }

        //  properties of users and WriterArchPlaces
        public async Task<List<User>> GetAllUsersWriterArchPlacesPaginatedAsync(int pageNumber, int pageSize)
        {
            int skip = (pageNumber - 1) * pageSize;
            var usersWithWriterArchPlacesRole = await context.Users
                .Where(u => u.UserRole == UserRole.WebTextWriter)
                .Include(u => u.WriterArchPlaces)
                .Skip(skip)
                .Take(pageSize)
                .ToListAsync();

            return usersWithWriterArchPlacesRole;
        }



        public async Task<PaginatedResult<User>> GetPaginatedUsersWriterArchPlacesAsync(int pageNumber, int pageSize)
        {
            var totalRecords = await context.Users
                .Where(u => u.UserRole == UserRole.WebTextWriter)
                .CountAsync();

            int skip = (pageNumber - 1) * pageSize;

            var usersWithWebTextWriterRole = await context.Users
                .Where(u => u.UserRole == UserRole.WebTextWriter)
                .Include(u => u.WriterArchPlaces)
                .Skip(skip)
                .Take(pageSize)
                .ToListAsync();

            return new PaginatedResult<User>
            {
                Data = usersWithWebTextWriterRole,
                TotalRecords = totalRecords,
                PageNumber = pageNumber,
                PageSize = pageSize
            };

        }
        // sum of users  who have WebTextWriter Role -means WriterArchPlaces, WriterMonuments, WriterMuseums,
        // NOT Subscriber user, these have privelledge to write comment and rate the records not create records- 
        public async Task<PaginatedResult<User>> GetPaginatedUsersWebTextWriterFilteredAsync(int pageNumber,
            int pageSize, List<Func<User, bool>> predicates)
        {
            var totalRecords = await context.Users
                .Where(u => u.UserRole == UserRole.WebTextWriter)
                .CountAsync();

            int skip = (pageNumber - 1) * pageSize;

            IQueryable<User> query = context.Users
                .Where(u => u.UserRole == UserRole.WebTextWriter)
                .Skip(skip)
                .Take(pageSize);

            if (predicates != null && predicates.Any())
            {
                query = query.Where(u => predicates.All(predicate => predicate(u)));
            }

            var usersWebTextWriters = await query.ToListAsync();

            return new PaginatedResult<User>
            {
                Data = usersWebTextWriters,
                TotalRecords = totalRecords,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }

        // here shows the user WriterArchPlaces -who  have role 'WebTextWriter'- by the Username 
        public async Task<User?> GetUserWriterArchPlacesByUsernameAsync(string username)
        {
            var userWriterArchPlaces = await context.Users
                .Where(u => u.UserRole == UserRole.WebTextWriter && u.Username == username)
                .SingleOrDefaultAsync();

            return userWriterArchPlaces;
        }

        public Task<List<User>> GetAllUsersWriterArchPlacesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PaginatedResult<User>> GetPaginatedUsersWriterArchPlacesFilteredAsync(int pageNumber, int pageSize,
            List<Func<User, bool>> predicates)
        {
            throw new NotImplementedException();
        }
    }
}
