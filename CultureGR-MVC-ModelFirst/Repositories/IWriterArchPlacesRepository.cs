using CultureGR_MVC_ModelFirst.Data;
using CultureGR_MVC_ModelFirst.Models;


namespace CultureGR_MVC_ModelFirst.Repositories
{
    public interface IWriterArchPlacesRepository
    {
        // a list of records of Archaeological Places appear in the site
        Task<List<Record>> GetWriterArchPlacesRecordsAsync(int id);
        Task<WriterArchPlaces?> GetByWorkPhoneNumberAsync(string WorkPhoneNumber);
        // show ALL users who are WriterArchPlaces
        Task<List<User>> GetAllUsersWriterArchPlacesAsync();
        // here below we ask the Paginated forr example want page 5 , 10 users of WriterArchPlaces
        Task<List<User>> GetAllUsersWriterArchPlacesPaginatedAsync(int pageNumber, int pageSize);
        // and here is to appear one user of WriterArchPlaces
        Task<User?> GetUserWriterArchPlacesByUsernameAsync(string username);

        Task<PaginatedResult<User>> GetPaginatedUsersWriterArchPlacesAsync(int pageNumber, int pageSize);
        Task<PaginatedResult<User>> GetPaginatedUsersWriterArchPlacesFilteredAsync(int pageNumber, int pageSize,
            List<Func<User, bool>> predicates);
    }
}
