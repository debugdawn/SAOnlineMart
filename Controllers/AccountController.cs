using Microsoft.AspNetCore.Mvc;
using WebApp2.Models;


namespace WebApp2.Controllers
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
            if (ModelState.IsValid)
            {
                if (model.Username == "Sarah" && model.Password == "Admin!123")
                {
                    return Redirect("http://localhost:5005/products");
                }
                else if (model.Username == "customer" && model.Password == "customer")
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid login attempt");
                }
            }
            return View(model);
        }
    }
}

