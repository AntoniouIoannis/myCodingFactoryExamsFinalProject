using CultureGR_MVC_ModelFirst.DTO;
using CultureGR_MVC_ModelFirst.Models;
using CultureGR_MVC_ModelFirst.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CultureGR_MVC_ModelFirst.Controllers
{
    public class TextEditorController : Controller
    {
        private readonly IApplicationService _applicationService;
        public List<Error> ErrorArray { get; set; } = new();

        public TextEditorController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        [HttpGet]
        [Authorize(Roles = "TextEditor")]
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
        public async Task<IActionResult> Signup(SubscriberSignupDTO SubscriberSignupDTO)
        {
            if (!ModelState.IsValid)
            {
                return View(SubscriberSignupDTO);
            }

            try
            {
                await _applicationService.SubscriberService.SignUpUserAsync(SubscriberSignupDTO);
                return RedirectToAction("Login", "User");
            }
            catch (Exception ex)
            {
                ErrorArray.Add(new Error("", ex.Message, ""));
                ViewData["ErrorArray"] = ErrorArray;
                return View();
            }
        }
    }
}



