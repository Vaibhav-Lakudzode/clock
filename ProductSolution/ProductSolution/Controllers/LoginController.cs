using Microsoft.AspNetCore.Mvc;

namespace ProductSolution.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
