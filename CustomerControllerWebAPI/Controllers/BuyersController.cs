using CustomerControllerWebAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerControllerWebAPI.Controllers
{
  
    [Route("api/[controller]")]
    [ApiController]
    public class BuyersController : Controller
    {

        private readonly ILogger<BuyersController> _logger;

        public BuyersController(ILogger<BuyersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<Seller> Get()
        {
            List<Seller> posts = new List<Seller>
            {
                new Seller { Name = "Vaibhav dada", Email="vaibhav@gmail.com" },
                new Seller { Name = "Aniket Bhau", Email = "isis@gmail.com" },
             };
            return posts;
        }
    }
}