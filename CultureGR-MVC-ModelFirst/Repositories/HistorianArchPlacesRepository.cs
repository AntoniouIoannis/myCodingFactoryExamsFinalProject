using CultureGR_MVC_ModelFirst.Core;
using CultureGR_MVC_ModelFirst.Data;
using CultureGR_MVC_ModelFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace CultureGR_MVC_ModelFirst.Repositories
{
    public class HistorianArchPlacesRepository : BaseRepository<HistorianArchPlaces>, IHistorianArchPlacesRepository
    {
        public HistorianArchPlacesRepository(CultureGRDBContext context)
            : base(context)
        {
        }

        public async Task<HistorianArchPlaces?> GetByWorkPhoneNumberAsync(string? workphoneNumber)
        {
            return await context.historianArchPlaces
                .Where(w => w.WorkPhoneNumber == workphoneNumber)
                .FirstOrDefaultAsync();
        }

        public async Task<List<Record>> GetHistorianArchPlacesRecordsAsync(int id)
        {
            List<Record> records;

            records = await context.historianArchPlaces    //list or recordsfrom certain HistorianArchPlaces 
                .Where(h => h.Id == id)                 // the specific id 
                .SelectMany(h => h.Records)             // the list of Archaeological Places witch APPROVED in the list of Places
                .ToListAsync();                         // make the list!!!!

            return records;
        }

        //  properties of users and HistorianArchPlaces
        public async Task<List<User>> GetAllUsersHistorianArchPlacesPaginatedAsync(int pageNumber, int pageSize)
        {
            int skip = (pageNumber - 1) * pageSize;
            var usersWithHistorianArchPlacesRole = await context.Users
                .Where(u => u.UserRole == UserRole.ChiefEditor)
                .Include(u => u.HistorianArchPlaces)
                .Skip(skip)
                .Take(pageSize)
                .ToListAsync();

            return usersWithHistorianArchPlacesRole;
        }



        public async Task<PaginatedResult<User>> GetPaginatedUsersHistorianArchPlacesAsync(int pageNumber, int pageSize)
        {
            var totalRecords = await context.Users
                .Where(u => u.UserRole == UserRole.ChiefEditor)
                .CountAsync();

            int skip = (pageNumber - 1) * pageSize;

            var usersWithChiefEditorRole = await context.Users
                .Where(u => u.UserRole == UserRole.ChiefEditor)
                .Include(u => u.HistorianArchPlaces)
                .Skip(skip)
                .Take(pageSize)
                .ToListAsync();

            return new PaginatedResult<User>
            {
                Data = usersWithChiefEditorRole,
                TotalRecords = totalRecords,
                PageNumber = pageNumber,
                PageSize = pageSize
            };

        }
        // sum of users  who have ChiefEditor Role -means HistorianArchPlaces, HistorianMonuments, HistorianMuseums,
        public async Task<PaginatedResult<User>> GetPaginatedUsersChiefEditorFilteredAsync(int pageNumber,
            int pageSize, List<Func<User, bool>> predicates)
        {
            var totalRecords = await context.Users
                .Where(u => u.UserRole == UserRole.ChiefEditor)
                .CountAsync();

            int skip = (pageNumber - 1) * pageSize;

            IQueryable<User> query = context.Users
                .Where(u => u.UserRole == UserRole.ChiefEditor)
                .Skip(skip)
                .Take(pageSize);

            if (predicates != null && predicates.Any())
            {
                query = query.Where(u => predicates.All(predicate => predicate(u)));
            }

            var usersChiefEditor = await query.ToListAsync();

            return new PaginatedResult<User>
            {
                Data = usersChiefEditor,
                TotalRecords = totalRecords,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }

        // here shows the user HistorianArchPlaces -who  have role 'Chief Editor'- by the Username 
        public async Task<User?> GetUserHistorianArchPlacesByUsernameAsync(string username)
        {
            var userHistorianArchPlaces = await context.Users
                .Where(u => u.UserRole == UserRole.ChiefEditor && u.Username == username)
                .SingleOrDefaultAsync();

            return userHistorianArchPlaces;
        }

        public Task<List<User>> GetAllUsersHistorianArchPlacesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PaginatedResult<User>> GetPaginatedUsersHistorianArchPlacesFilteredAsync(int pageNumber, int pageSize,
            List<Func<User, bool>> predicates)
        {
            throw new NotImplementedException();
        }

        Task<WriterArchPlaces?> IHistorianArchPlacesRepository.GetByWorkPhoneNumberAsync(string WorkPhoneNumber)
        {
            throw new NotImplementedException();
        }
    }
}
