using CultureGR_MVC_ModelFirst.DTO;

namespace CultureGR_MVC_ModelFirst.Services
{
    public interface ISubscriberService
    {
        Task SignUpUserAsync(SubscriberSignupDTO subscriberSignupDTO);
    }
}

