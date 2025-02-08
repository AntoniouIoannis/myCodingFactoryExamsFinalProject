using CultureGR_MVC_ModelFirst.DTO;
namespace CultureGR_MVC_ModelFirst.Services
{
    public class SubscriberService : ISubscriberService
    {
        public async Task SignUpUserAsync(SubscriberSignupDTO subscriberSignupDTO)
        {
            // SignUp Complete!!
            await Task.CompletedTask;
        }
    }
}
