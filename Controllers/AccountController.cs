using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (model.Username == "patricia" &&
                model.Password == "portfolio123")
            {
                return RedirectToAction("Index", "Projects");
            }

            ViewBag.Error = "Invalid username or password.";

            return View(model);
        }

        public IActionResult Logout()
        {
            return RedirectToAction("Login");
        }
    }
}