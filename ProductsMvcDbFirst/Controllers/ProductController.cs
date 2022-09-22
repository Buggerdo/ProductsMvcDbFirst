using Microsoft.AspNetCore.Mvc;
using ProductsMvcDbFirst.Models;
using ProductsMvcDbFirst.Models.Products;


namespace ProductsMvcDbFirst.Controllers
{
    public class ProductController : Controller
    {
        ProductsMvcDbFirstContext _Db = new ProductsMvcDbFirstContext();
        public IActionResult Index()
        {
            List<ProductListItem> allProducts= _Db.Products
                .Select(p => new ProductListItem() 
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price
                }).ToList();
            return View("ProductIndex", allProducts);
        }

        public IActionResult Create()
        {
            return View("ProductCreate");
        }

        public IActionResult AddProductToDb(Product p) 
        {
            p.LastUpdated = DateTime.Now;
            _Db.Products.Add(p);
            _Db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
