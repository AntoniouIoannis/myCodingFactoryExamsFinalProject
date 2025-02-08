using CultureGR_MVC_ModelFirst.Data;

namespace CultureGR_MVC_ModelFirst.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CultureGRDBContext _context;

        public UnitOfWork(CultureGRDBContext context)
        {
            _context = context;
        }


        public WriterArchPlacesRepository WriterArchPlacesRepository => new(_context);

        public SubscriberRepository SubscriberRepository => new(_context);
        public HistorianArchPlacesRepository HistorianArchPlacesRepository => new(_context);



        public UserRepository UserRepository => new(_context);

        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
