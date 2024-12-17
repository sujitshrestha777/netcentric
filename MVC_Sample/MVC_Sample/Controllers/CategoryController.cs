using Microsoft.AspNetCore.Mvc;
using MVCeStore.Models;

namespace MVC_Sample.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult list()
        {
            List<Category> products = new List<Category>
            {
                new Category
                {
                   Id = 101,
                   Name = "Table",
                   Description = "Table is a wooden furniture.",
                   Price = 15000,

                },
                new Category
                {
                  Id = 205,
                   Name = "Headphones",
                    Description = "Headphones are for listening to audio.",
                        Price = 3000

                },
                new Category
                {
                    Id = 3,
                    Name = "Watch",
                    Description = "Watch is a electronic wearable devices.",
                    Price = 5000
                }
            };
            ViewData["Title"] = products;
            return View(products);
        }
    }
}
