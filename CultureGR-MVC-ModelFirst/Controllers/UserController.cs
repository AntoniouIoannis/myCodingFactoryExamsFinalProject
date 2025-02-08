using System.Security.Claims;
using CultureGR_MVC_ModelFirst.Core;
using CultureGR_MVC_ModelFirst.DTO;
using CultureGR_MVC_ModelFirst.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace CultureGR_MVC_ModelFirst.Controllers
{
    public class UserController : Controller
    {
        private readonly IApplicationService _applicationService;

        public string? Username { get; private set; }
        public string? Password { get; private set; }
        public string? Email { get; private set; }
        public string? WorkPhoneNumber { get; private set; }
        public UserRole? UserRole { get; private set; }


        public UserController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(UserSignUp model)
        {
            if (ModelState.IsValid)
            {

                if (model.Password != model.RePassword)
                {
                    ModelState.AddModelError(string.Empty, "Passwords do not match.");
                    return View(model);
                }

                // Εδώ πρέπει να προσθέσουμε τη λογική για την αποθήκευση του χρήστη στην βάση
                var user = new UserSignUp();
                {
                    Username = model.Username;
                    Password = model.Password;
                    Email = model.Email;
                    UserRole = model.UserRole;
                };

                var success = await _applicationService.UserService.RegisterUserAsync(user);

                if (success)
                {
                    return RedirectToAction("Login", "User"); // Ανακατεύθυνση στη σελίδα Login μετά την επιτυχή εγγραφή
                }

                ModelState.AddModelError(string.Empty, "An error occurred during registration. Please try again.");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Login()
        {
            ClaimsPrincipal principal = HttpContext.User;
            if (!principal.Identity!.IsAuthenticated)
            {
                return View();
            }
            return RedirectToAction("Index", "User");
        }

        [HttpPost]
        public async Task<ActionResult> Login(UserFilterdDTO credentials)
        {
            var user = await _applicationService.UserService.VerifyAndGetUserAsync(credentials);

            if (user == null)
            {
                ViewData["ValidateMessage"] = "Error. Username / Password invalid";
                return View();
            }

            List<Claim> claims = new()
            {
                new Claim(ClaimTypes.NameIdentifier, credentials.Username!),

            };

            ClaimsIdentity identity = new(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            AuthenticationProperties properties = new()
            {
                AllowRefresh = true,
                IsPersistent = credentials.KeepLoggedIn
            };

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(identity), properties);

            return RedirectToAction("Index", "User");
        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "User");
        }

    }
}
