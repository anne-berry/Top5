using Microsoft.AspNetCore.Mvc;

namespace Top5.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Show(string day)
        {
            string[] specials_for_the_day =
            {
                "Stew peas",
                "Escovitch fish",
                "Mannish water"
            };
            ViewData["Title"] = "Menu";
            ViewBag.Day = day;
            ViewBag.Specials = specials_for_the_day;
            ViewBag.Price = 1500;
            return View();
        }
    }
}
