namespace CultureGR_MVC_ModelFirst.Services
{
    public interface IApplicationService
    {
        UserService UserService { get; }
        ISubscriberService SubscriberService { get; }

    }
}
