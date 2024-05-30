using Microsoft.AspNetCore.Mvc;

namespace ProductSolution.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
    }
}
