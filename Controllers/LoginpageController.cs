using Microsoft.AspNetCore.Mvc;

namespace Final_project.Controllers
{
    public class LoginpageController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                ViewBag.ErrorMessage = "Username and Password are required.";
                return View();
            }


            TempData["Message"] = $"Welcome, {username}!";
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Logout()
        {

            TempData["Message"] = "You have been logged out.";
            return RedirectToAction("Login");
        }
    }
}
