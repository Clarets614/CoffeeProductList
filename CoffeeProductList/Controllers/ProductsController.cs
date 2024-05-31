using CoffeeProductList.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeProductList.Controllers
{
    public class ProductsController : Controller
    {
        ProductsDbContext dbContext = new ProductsDbContext();
        [HttpGet]
        public IActionResult Index()
        {
            List<Product> result = dbContext.Products.ToList();
            return View(result);
        }

        public IActionResult Details(int id)
        {
            Product result = dbContext.Products.FirstOrDefault(p => p.Id == id);
            return View(result);   
        }

        [HttpPost]
        //public IActionResult Details(string category)
        //{
        //    string categories = dbContext.Products.Select(p => p.Category).Distinct().ToList();
        //    Product products = (Product)dbContext.Products.Where(p => p.Category == category);

        //}
        public IActionResult Details(string category)
        {
            List<Product> result = dbContext.Products.Where(p => p.Category == category).ToList();
            return View(result);
        }

    }
}
