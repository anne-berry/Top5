using Microsoft.AspNetCore.Mvc;

namespace Top5.Controllers
{
    public class Top5Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Notlist(
            string anything)

        {
            ViewData["Asked"] = anything;
            return View();
        }

        [HttpGet("About-my-list")]
        public IActionResult About()
        {
            return View();
        }

        [HttpGet("rank/{id}")]
        public IActionResult Number(int id)
        {
            string[] items =
             {
                "Ackee and Saltfish",
                "Curry Goat",
                "Jerk Chicken",
                "Oxtail",
                "Fried Dumpling",
                "Jerk Pork", 
                "Fried Fish",
            };
            if (id> items.Length || id <1)
            {
                return NotFound();
            }
            ViewData["Items"] = $"{items[id - 1]}";
            return View();
        } 

        }
    }
