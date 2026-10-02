using Microsoft.AspNetCore.Mvc;
using Top5.Models;

namespace Top5.Controllers
{
    public class MenuController : Controller
    {
        private List<Dish> specials_for_the_day = new List<Dish>
        {
            new Dish {Id =1, Name = " Stew peas", Price = 1500, IsSpicy= false },
            new Dish {Id= 2, Name = "Escovitch fish", Price = 1800 ,  IsSpicy = true },
            new Dish {Id = 3,Name = "Mannish Water", Price =  900, IsSpicy = true },

        };
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Show(string day)
        {
            //string[] specials_for_the_day =
            //{
            //    "Stew peas",
            //    "Escovitch fish",
            //    "Mannish water"
            //};
            //ViewData["Title"] = "Menu";
            //ViewBag.Day = day;
            //ViewBag.Specials = specials_for_the_day;
            //ViewBag.Price = 1500;
            return View(specials_for_the_day);
        }
        [HttpGet("menu/order/{id:int}")]
        public IActionResult Order(int id)
        {
            foreach (Dish each_dish in specials_for_the_day)
            {
                if (each_dish.Id == id)
                {
                    TempData["Message"] = $"Added {each_dish.Name} to your order";
                    return RedirectToAction("Show");
                }
            }
            return NotFound();
        }

    }
    
}
