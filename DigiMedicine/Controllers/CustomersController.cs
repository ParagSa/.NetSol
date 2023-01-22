using Microsoft.AspNetCore.Mvc;

namespace DigiMedicine.Controllers
{
    public class CustomersController : Controller
    {
        private readonly IConfiguration _configuration;
        public CustomersController(IConfiguration _configuration, IConfiguration configurationManager)
        {
           _configuration = configurationManager;

        }

        //public IActionResult Index()
        //{

        //  return View();
        //}

    }
}
