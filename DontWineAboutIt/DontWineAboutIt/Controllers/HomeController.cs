using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DontWineAboutIt.Models;

namespace DontWineAboutIt.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string name, int maxPrice, int minPoints)
        {
            Wine wineSearch = new Wine();
            string Name = name;
            int MaxPrice = maxPrice;
            int MinPoints = minPoints;
            return wineSearch;
        }

        [HttpPost]
        public IActionResult Result()
        {
            return RedirectToAction("Results", wineList);
        }
    }
}