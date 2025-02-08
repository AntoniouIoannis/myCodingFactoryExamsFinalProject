namespace CultureGR_MVC_ModelFirst.Repositories
{
    public interface IBaseRepository<T>
    {
        // Basic set of CRUD Actions
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        Task UpdateAsync(T entity);
        Task<bool> DeleteAsync(int id);
        Task<T?> GetAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<int> GetCountAsync();
    }
}
