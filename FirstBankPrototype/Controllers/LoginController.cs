using Microsoft.AspNetCore.Mvc;

namespace FirstBankApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            string validUsername = "user";
            string validPassword = "user@123";

            if (username == validUsername && password == validPassword)
            {
                // Authentication successful, redirect to dashboard or home page
                TempData["validMsg"] = "Welcome User";
                return RedirectToAction("Dashboard", "Login");
            }
            else
            {
                // Authentication failed, show error message
                TempData["invalidMsg"] = "Invalid username or password";
                return RedirectToAction("Index", "Login");
            }
        }

        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
