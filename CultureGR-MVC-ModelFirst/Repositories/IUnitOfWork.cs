namespace CultureGR_MVC_ModelFirst.Repositories
{
    public interface IUnitOfWork
    {
        UserRepository UserRepository { get; }
        WriterArchPlacesRepository WriterArchPlacesRepository { get; }
        SubscriberRepository SubscriberRepository { get; }
        HistorianArchPlacesRepository HistorianArchPlacesRepository { get; }

        Task<bool> SaveAsync();
    }
}
