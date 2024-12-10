using Microsoft.AspNetCore.Mvc;
using MVCeStore.Models;

namespace MVCeStore.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
        public IActionResult List()
        {

            List<Category> category = new List<Category>
            {
                new Category
                {
                    Id = 1,
                    Name = "Laptop",
                    Description ="Laptop is a electronic device.",
                    Price = 50000
                },
                new Category
                {
                    Id = 2,
                    Name = "Phone",
                    Description = "Phone is a hand-held devices.",
                    Price = 20000
                },
                new Category
                {
                    Id = 3,
                    Name = "Watch",
                    Description = "Watch is a electronic wearable devices.",
                    Price = 5000
                }
            };
            return View(category);
        }
    }
}
