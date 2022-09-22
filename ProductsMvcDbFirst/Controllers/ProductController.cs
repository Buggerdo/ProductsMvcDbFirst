using Microsoft.AspNetCore.Mvc;

namespace ProductsMvcDbFirst.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        // save to database
        public IActionResult AddProductToDb() 
        {
            throw new NotImplementedException();
        }
    }
}
