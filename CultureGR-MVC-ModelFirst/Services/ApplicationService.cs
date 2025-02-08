using AutoMapper;
using CultureGR_MVC_ModelFirst.Repositories;

namespace CultureGR_MVC_ModelFirst.Services
{
    public class ApplicationService(IUnitOfWork unitOfWork, IMapper mapper, ISubscriberService subscriberService) : IApplicationService
    {
        public UserService UserService => new(_unitOfWork, _mapper);

        public required ISubscriberService SubscriberService { get; init; } = subscriberService;

        public ISubscriberService? subscriberService { get; }

        private readonly IUnitOfWork _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        private readonly IMapper _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }
}
