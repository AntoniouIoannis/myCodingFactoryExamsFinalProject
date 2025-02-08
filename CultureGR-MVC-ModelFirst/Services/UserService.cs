using CultureGR_MVC_ModelFirst.Data;
using CultureGR_MVC_ModelFirst.DTO;
using CultureGR_MVC_ModelFirst.Repositories;
using Serilog;

namespace CultureGR_MVC_ModelFirst.Services
{
    public class UserService(IUnitOfWork unitOfWork, AutoMapper.IMapper mapper) : IUserService
    {
        private readonly IUnitOfWork _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        private readonly AutoMapper.IMapper _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        private readonly ILogger<UserService> _logger = new LoggerFactory().AddSerilog().CreateLogger<UserService>();

        public async Task<List<User>> GetAllUsersFiltered(int pageNumber, int pageSize,
            UserFilterdDTO userFiltersDTO)
        {
            List<User> users;
            List<Func<User, bool>> predicates = new();

            try
            {
                if (!string.IsNullOrEmpty(userFiltersDTO.Username))
                {
                    predicates.Add(u => u.Username == userFiltersDTO.Username);
                }
                if (!string.IsNullOrEmpty(userFiltersDTO.Email))
                {
                    predicates.Add(u => u.Email == userFiltersDTO.Email);
                }


                users = await _unitOfWork.UserRepository
                    .GetAllUsersFilteredPaginatedAsync(pageNumber, pageSize, predicates);
            }
            catch (Exception e)
            {
                _logger.LogError("{Message}{Exception}", e.Message, e.StackTrace);
                throw;
            }
            return users;
        }

        public Task<List<User>> GetAllUsersFiltered(int pageNumber, int pageSize, UserFiltersDTO userFiltersDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<User?> GetUserByUsernameAsync(string username)
        {
            User? user = null;

            try
            {
                user = await _unitOfWork.UserRepository.GetByUsernameAsync(username);
            }
            catch (Exception e)
            {
                _logger.LogError("{Message}{Excpetion}", e.Message, e.StackTrace);
            }
            return user;
        }

        public async Task<User?> VerifyAndGetUserAsync(UserLoginDTO credentials)
        {
            User? user;

            try
            {
                user = await _unitOfWork.UserRepository.GetUserAsync(credentials.Username!, credentials.Password!);
                _logger.LogInformation("{Message}", "User: " + user + " found and returned.");   // ToDo toString()
            }
            catch (Exception ex)
            {
                _logger.LogError("{Message}{Exception}", ex.Message, ex.StackTrace);
                throw;
            }
            return user;
        }

        public async Task<User?> VerifyAndGetUserAsync(UserFilterdDTO credentials)
        {
            User? user = null;
            try
            {
                user = await _unitOfWork.UserRepository.GetUserAsync(credentials.Username!, credentials.Password!);
                _logger.LogInformation("{Message}", "User: " + user + " found and returned.");
            }
            catch (Exception ex)
            {
                _logger.LogError("{Message}{Exception}", ex.Message, ex.StackTrace);
                throw;
            }
            return user;
        }

        public async Task<bool> RegisterUserAsync(UserSignUp user)
        {
            // Ελέγχουμε αν υπάρχει ήδη χρήστης με το ίδιο username
            var existingUser = await _unitOfWork.UserRepository.GetByUsernameAsync(user?.Username);
            if (existingUser != null)
            {
                // Αν υπάρχει ήδη χρήστης με το ίδιο username, επιστρέφουμε false
                return false;
            }

            // Αν δεν υπάρχει, δημιουργούμε τον νέο χρήστη και αποθηκεύουμε τα δεδομένα του
            var newUser = new User
            {
                Username = user.Username,
                Password = user.Password,
                Email = user.Email,
                WorkPhoneNumber = user.PhoneNumber
            };

            try
            {
                // Αποθηκεύουμε τον νέο χρήστη στη βάση δεδομένων
                await _unitOfWork.UserRepository.AddAsync(newUser);
                await _unitOfWork.SaveAsync(); // Καλούμε το SaveChanges() για να αποθηκεύσουμε στην βάση
                return true; // Επιστρέφουμε true αν η καταχώρηση είναι επιτυχής
            }
            catch (Exception e)
            {
                _logger.LogError("{Message}{Exception}", e.Message, e.StackTrace);
                return false; // Αν συμβεί κάποιο σφάλμα, επιστρέφουμε false
            }
        }
    }
}
