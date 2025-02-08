using CultureGR_MVC_ModelFirst.Data;
using CultureGR_MVC_ModelFirst.Models;


namespace CultureGR_MVC_ModelFirst.Repositories
{
    public interface IHistorianArchPlacesRepository
    {
        // HistorianArchPlaces  approved the records only for Arhaeological PLaces  has the Role of ChiefEditor

        // a list of records of Archaeological Places appear in the site
        Task<List<Record>> GetHistorianArchPlacesRecordsAsync(int id);
        Task<WriterArchPlaces?> GetByWorkPhoneNumberAsync(string WorkPhoneNumber);
        // show ALL users who are WriterArchPlaces
        Task<List<User>> GetAllUsersHistorianArchPlacesAsync();
        // here below we ask the Paginated forr example want page 5 , 10 users of HistorianArchPlaces
        Task<List<User>> GetAllUsersHistorianArchPlacesPaginatedAsync(int pageNumber, int pageSize);
        // and here is to appear one user of HistorianArchPlaces
        Task<User?> GetUserHistorianArchPlacesByUsernameAsync(string username);

        Task<PaginatedResult<User>> GetPaginatedUsersHistorianArchPlacesAsync(int pageNumber, int pageSize);
        Task<PaginatedResult<User>> GetPaginatedUsersHistorianArchPlacesFilteredAsync(int pageNumber, int pageSize,
            List<Func<User, bool>> predicates);
    }
}
