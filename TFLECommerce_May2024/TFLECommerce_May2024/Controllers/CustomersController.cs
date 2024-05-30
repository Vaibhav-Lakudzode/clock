using Microsoft.AspNetCore.Mvc;
using TFLECommerce_May2024.Models;

namespace TFLECommerce_May2024.Controllers
{
    public class CustomersController : Controller
    {
       
        public IActionResult Index()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 23, Name = "Modijii",Email="modi1253@gmail.com",Phone="95428711333" });
            customers.Add(new Customer { Id = 23, Name = "Rahul Gandi", Email = "rahulgandi1253@gmail.com", Phone = "95428711333" });
            customers.Add(new Customer { Id = 23, Name = "Ajit dada", Email = "ajitdada1253@gmail.com", Phone = "95428711333" });


            ViewData["allproducts"] = customers;
            return View();

            /*return Json(new { Id=23, Name="Vaibhav",
                               Email="vaibhav457@gmail.com", Phone,
                              });*/

        }
        public IActionResult Delete()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        
    }
}
